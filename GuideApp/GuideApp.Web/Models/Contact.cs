using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GuideApp.Web.Models
{
    public class Contact
    {
        [Key]
        [Display(Name ="Kişi Kimliği")]
        public int ContactId { get; set; }

        [Display(Name ="Kişi Adı")]
        public string FirstName { get; set; }
        [Display(Name ="Kişi Soyadı")]
        public string LastName { get; set; }

        [Display(Name ="Firma Adı")]
        public string Company { get; set; }

        [Display(Name = "İletişim Bilgi Kimliği")]
        public int ContactInfoId { get; set; }
        public ContactInformation ContactInformation { get; set; }

    }

    public class ContactInformation
    {
        [Key]
        [Display(Name ="İletişim Bilgi Kimliği")]
        public int ContactInfoId { get; set; }

        [Display(Name ="Telefon Numarası")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name ="E-posta Adresi")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name ="Lokasyon")]
        public string Location { get; set; }
        [Display(Name = "Kişi Kimliği")]
        public int ContactId { get; set; }

        [Display(Name ="Kişi Adı")]
        public Contact Contact { get; set; }
    }
}
