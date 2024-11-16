using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 30 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(20, 3000, ErrorMessage = "Price must be between 20 and 3000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        [MinLength(10, ErrorMessage = "Description must be at least 10 characters.")]
        public string Description { get; set; }
    }
}
