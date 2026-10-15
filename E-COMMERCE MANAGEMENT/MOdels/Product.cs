using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_COMMERCE_MANAGEMENT.MOdels
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(2)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
        [Required,Range(0.01,1000000)]
        public decimal Price { get; set; }
        [Required, Range(0, 1000000)]
        public int StockQuantity { get; set; }

        

        [ForeignKey (nameof (category))]
        public int categoryId { get; set; }
        public Category category { get; set; }
        public ICollection<OrderItem> orderItems { get; set; }


    }
}
