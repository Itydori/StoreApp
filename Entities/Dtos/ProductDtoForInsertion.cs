using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDtoForInsertion 
    {
        [Required(ErrorMessage = "Product Name is REQUIRED")]

        public String? ProductName { get; init; } = String.Empty;
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        [Required(ErrorMessage = "Product Price is REQUIRED")]
        public decimal Price { get; init; }
        [Required(ErrorMessage = "Please select a category.")]

        public int CategoryId { get; set; }   //Foreign Key

    }
}