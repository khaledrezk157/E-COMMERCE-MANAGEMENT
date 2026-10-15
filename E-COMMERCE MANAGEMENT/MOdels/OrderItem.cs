using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace E_COMMERCE_MANAGEMENT.MOdels
{
    public class OrderItem
    {
        public int Id { get; set; }
        [Required,Range(1,1000)]
        public int Quantity { get; set; }
        [Required,Range(0.01,1000000)]
        public decimal UniteOfPrice { get; set; }

        [ForeignKey(nameof(order))]
        public int OrderId { get; set; }
        public Order order { get; set; }
        [ForeignKey(nameof(products))]
        public int ProductId { get; set; }
        public Product products { get; set; }

    }
}
