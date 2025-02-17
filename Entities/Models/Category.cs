namespace Entities.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String? CategoryName { get; set; } = String.Empty;

        public ICollection<Product>? Products { get; set; } // Collection Navigation Property
        public Category SingleOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}