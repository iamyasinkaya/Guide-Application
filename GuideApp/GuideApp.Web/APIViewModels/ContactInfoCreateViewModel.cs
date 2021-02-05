using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideApp.Web.APIViewModels
{
    public class ContactInfoCreateViewModel
    {
        [Display(Name = "Telefon Numarası")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-posta Adresi")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Lokasyon")]
        public string Location { get; set; }
        [Display(Name = "Kişi Kimliği")]
        public int ContactId { get; set; }
    }
}
