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
    public class ContactInfoApiController : ControllerBase
    {
        private readonly GuideAppContext _context;

        public ContactInfoApiController(GuideAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ContactInformation>> GetContactInfoItems()
        {
            return await _context.ContactInformation.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ContactInformation>> GetContactInfoItem(int Id)
        {
            var contactInfo = await _context.ContactInformation.FindAsync(Id);
            if (contactInfo == null)
            {
                return NotFound();
            }

            return contactInfo;
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateContactItem(int Id, ContactInformation contactInformation)
        {
            if (Id != contactInformation.ContactInfoId)
            {
                return BadRequest();
            }

            var contactItem = await _context.ContactInformation.FindAsync(Id);
            if (contactItem == null)
            {
                return NotFound();
            }

            contactItem.PhoneNumber = contactInformation.PhoneNumber;
            contactItem.EmailAddress = contactInformation.EmailAddress;
            contactItem.Location = contactInformation.Location;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ContactExists(Id))
            {

                return NotFound();
            }

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<ContactInformation>> CreateContactItem(ContactInformation contactInformation)
        {
            var contactItem = new ContactInformation
            {
                PhoneNumber = contactInformation.PhoneNumber,
                EmailAddress = contactInformation.EmailAddress,
                Location = contactInformation.Location,
                ContactId = contactInformation.ContactId
            };

            _context.ContactInformation.Add(contactItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetContactInfoItem),
                new { id = contactItem.ContactInfoId },
                new ContactInformation
                {
                    ContactInfoId = contactInformation.ContactInfoId,
                    PhoneNumber = contactInformation.PhoneNumber,
                    EmailAddress = contactInformation.EmailAddress,
                    Location = contactInformation.Location
                });
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteContactItem(int Id)
        {
            var contactInfoItem = await _context.ContactInformation.FindAsync(Id);
            if (contactInfoItem == null)
            {
                return NotFound();
            }

            _context.ContactInformation.Remove(contactInfoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool ContactExists(int Id) => _context.ContactInformation.Any(e => e.ContactInfoId == Id);
    }
}
