using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuideApp.Web.Data;
using GuideApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GuideApp.Web.Controllers
{
    public class ContactInformationController : Controller
    {
        private readonly GuideAppContext _context;

        public ContactInformationController(GuideAppContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IActionResult> Index()
        {
            var contactInfoList = await _context.ContactInformation
                .Include(x=>x.Contact)
                .ToListAsync();

            return View(contactInfoList);
        }

        [HttpGet]
        public IActionResult NewContactInfo()
        {
            List<SelectListItem> contacts = (from i in _context.Contact.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.FirstName,
                                                 Value = i.ContactId.ToString()
                                             }).ToList();

            ViewBag.Contacts = contacts;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewContactInfo([Bind("PhoneNumber,EmailAddress,Location,ContactId")] ContactInformation contactInformation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(entity: contactInformation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Contact");
                }

            }
            catch (DbUpdateException /* ex */)
            {

                ModelState.AddModelError("", "Unable to save changes. " +
            "Try again, and if the problem persists " +
            "see your system administrator.");
            }

            return View(contactInformation);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContactInfo(int Id)
        {
            var contactInfo = await _context.ContactInformation.FindAsync(Id);

            return View(contactInfo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateContactInfo(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var contactInfoToUpdate = await _context.ContactInformation
                
                .FirstOrDefaultAsync(x => x.ContactInfoId == Id);
            if (await TryUpdateModelAsync<ContactInformation>(
                contactInfoToUpdate, "", c => c.PhoneNumber, c => c.EmailAddress, c => c.Location, c => c.ContactId))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Contact");
                }
                catch (DbUpdateException /*ex*/)
                {

                    ModelState.AddModelError("", "Unable to save changes. " +
                "Try again, and if the problem persists, " +
                "see your system administrator.");
                }
            }
            return View(contactInfoToUpdate);
        }

        public async Task<IActionResult> DetailContactInfo(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var contacntInfo = await _context.ContactInformation
                .FirstOrDefaultAsync(x => x.ContactInfoId == Id);

            if (contacntInfo == null)
            {
                return NotFound();
            }

            return View(contacntInfo);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveContactInfo(int? Id, bool? saveChangesError = false)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var contactInfo = await _context.ContactInformation
                .AsNoTracking().FirstOrDefaultAsync(x => x.ContactInfoId == Id);
            if (contactInfo == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                            "Delete failed. Try again, and if the problem persists " +
                            "see your system administrator.";
            }

            return View(contactInfo);
        }


        [HttpPost, ActionName("RemoveContactInfo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveContactInfoConfirmed(int Id)
        {
            var contactInfo = await _context.ContactInformation.FindAsync(Id);
            if (contactInfo == null)
            {
                return NotFound();
            }
            try
            {
                _context.ContactInformation.Remove(contactInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /*ex*/)
            {

                return RedirectToAction(nameof(RemoveContactInfo), new { id = Id, saveChangesError = true });
            }
        }

        
        

    }
}
