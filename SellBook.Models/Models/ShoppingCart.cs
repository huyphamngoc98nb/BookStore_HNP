using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBook.Models.Models
{
    public class ShoppingCart
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [Range(1, 1000, ErrorMessage = "Value must be between 1 to 1000!")]
        public int Count { get; set; }

        [NotMapped]
        public double Price { get; set; }
    }
}
