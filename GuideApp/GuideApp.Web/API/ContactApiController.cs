using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuideApp.Web.Data;
using GuideApp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuideApp.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {
        private readonly GuideAppContext _guideAppContext;

        public ContactApiController(GuideAppContext guideAppContext)
        {
            _guideAppContext = guideAppContext;
        }

        //GET: api/ContactApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContactItems()
        {
            return await _guideAppContext.Contact.ToListAsync();
        }

        //GET: api/ContactApi/Id

        [HttpGet("{Id}")]
        public async Task<ActionResult<Contact>> GetContactItem(int Id)
        {
            var contact = await _guideAppContext.Contact.FindAsync(Id);
            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        //PUT: api/ContactApi/Id
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateContactItem(int Id, Contact contact)
        {
            if (Id != contact.ContactId)
            {
                return BadRequest();
            }

            var contactItem = await _guideAppContext.Contact.FindAsync(Id);
            if (contactItem == null)
            {
                return NotFound();
            }

            contactItem.FirstName = contact.FirstName;
            contactItem.LastName = contact.LastName;
            contactItem.Company = contact.Company;

            try
            {
                await _guideAppContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ContactExists(Id))
            {

                return NotFound();
            }

            return NoContent();
        }
        
        //POST: api/ContactApi
        [HttpPost]
        public async Task<ActionResult<Contact>> CreateContactItem(Contact contact)
        {
            var contactItem = new Contact
            {
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Company = contact.Company
            };

            _guideAppContext.Contact.Add(contactItem);
            await _guideAppContext.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetContactItem),
                new { id = contactItem.ContactId },
                new Contact
                {
                    ContactId = contact.ContactId,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    Company = contact.Company
                });
        }

        //DELETE: api/ContactApi/Id
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteContactItem(int Id)
        {
            var contactItem = await _guideAppContext.Contact.FindAsync(Id);
            if (contactItem == null)
            {
                return NotFound();
            }

            _guideAppContext.Contact.Remove(contactItem);
            await _guideAppContext.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactExists(int Id) => _guideAppContext.Contact.Any(e => e.ContactId == Id);

    }
}
