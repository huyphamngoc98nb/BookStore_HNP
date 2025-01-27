using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBook.Models.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    }
}
