using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuideApp.Web.Data;
using GuideApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GuideApp.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly GuideAppContext _context;
        private readonly ILogger<ContactController> _logger;
        private readonly IDistributedCache _distributedCache;
        private GuideAppContext @object;

        public ContactController(GuideAppContext context, ILogger<ContactController> logger, IDistributedCache distributedCache)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _distributedCache = distributedCache ?? throw new ArgumentNullException(nameof(distributedCache));
        }

       

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            var contacts = from s in _context.Contact
                           select s;
            int pageSize = 3;
            return View(await PaginatedList<Contact>.CreateAsync(contacts.AsNoTracking(), pageNumber ?? 1, pageSize));


        }



        [HttpGet]
        public IActionResult NewContact()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewContact([Bind("FirstName", "LastName", "Company")] Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(entity: contact);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation($"{contact.FirstName + contact.LastName} adında yeni kullanıcı oluşturuldu.");
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {

                ModelState.AddModelError("", "Unable to save changes. " +
            "Try again, and if the problem persists " +
            "see your system administrator.");
            }

            return View(contact);
        }


        [HttpGet]
        public async Task<IActionResult> UpdateContact(int Id)
        {
            var contact = await _context.Contact.FindAsync(Id);

            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var contactToUpdate = await _context.Contact.FirstOrDefaultAsync(c => c.ContactId == Id);
            if (await TryUpdateModelAsync<Contact>(
                contactToUpdate, "", c => c.FirstName, c => c.LastName, c => c.Company))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    _logger.LogInformation($"{contactToUpdate.ContactId} Id'i kullanıcı üzerinde değişiklik yapıldı.");
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /*ex*/)
                {

                    ModelState.AddModelError("", "Unable to save changes. " +
                "Try again, and if the problem persists, " +
                "see your system administrator.");
                }
            }
            return View(contactToUpdate);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveContact(int? Id, bool? saveChangesError = false)
        {
            if (Id == null)
            {
                _logger.LogError($"{Id} bos olmasından dolayı sayfa bulunamadı.");
                return NotFound();
            }

            var contact = await _context.Contact.AsNoTracking().FirstOrDefaultAsync(c => c.ContactId == Id);

            if (contact == null)
            {
                _logger.LogError($"{contact} bos olmasından dolayı sayfa bulunamadı.");
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
            "Delete failed. Try again, and if the problem persists " +
            "see your system administrator.";
            }

            return View(contact);
        }

        [HttpPost, ActionName("RemoveContact")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveContactConfirmed(int Id)
        {

            var contact = await _context.Contact.FindAsync(Id);
            if (contact == null)
            {
                _logger.LogError($"{contact} bos olmasından dolayı sayfa bulunamadı.");
                return NotFound();
            }
            try
            {
                _context.Contact.Remove(contact);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"{contact.ContactId} numaralı kullanıcı başarılı bir şekilde silindi.");
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /*ex*/)
            {

                return RedirectToAction(nameof(RemoveContact), new { id = Id, saveChangesError = true });
            }

        }

        public async Task<IActionResult> DetailContact(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }


            var contact = await _context.Contact
                .Include(x => x.ContactInformation)
                .FirstOrDefaultAsync(x => x.ContactId == Id);

            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
    }
}
