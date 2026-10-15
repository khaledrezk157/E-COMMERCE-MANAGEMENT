using System.ComponentModel.DataAnnotations;

namespace E_COMMERCE_MANAGEMENT.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(2)]
        public string Name { get; set; }

        
        [Required, Range(0.01, 1000000)]
        public decimal Price { get; set; }
        [Required, Range(0, 1000000)]
        public int StockQuantity { get; set; }



    }
}
