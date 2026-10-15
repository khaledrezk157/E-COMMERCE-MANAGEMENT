using System.ComponentModel.DataAnnotations;

namespace E_COMMERCE_MANAGEMENT.MOdels
{
    public class Category
    {
        public int Id { get; set; }
        [Required,MinLength(2),MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }

    public ICollection<Product> products {  get; set; }
    
    
    
    
    }
}
