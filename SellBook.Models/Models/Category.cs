using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SellBook.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Model")]
        [Range(1, 100, ErrorMessage ="Display Order must be between 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
