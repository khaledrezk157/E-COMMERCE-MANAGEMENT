using System.ComponentModel.DataAnnotations;

namespace E_COMMERCE_MANAGEMENT.MOdels
{
    public class User
    {
        public int ID { get; set; }
        [Required,MaxLength(100),MinLength(3)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

    public ICollection<Order> orders {  get; set; }   
    }
}
