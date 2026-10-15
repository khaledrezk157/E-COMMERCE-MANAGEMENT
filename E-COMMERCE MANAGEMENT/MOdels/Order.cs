using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_COMMERCE_MANAGEMENT.MOdels
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public DateTime orderDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }

        [ForeignKey(nameof(users))]
        public int UserId { get; set; }
        public User users { get; set; }


        public ICollection<OrderItem> orderItems { get; set; }
    }

}
