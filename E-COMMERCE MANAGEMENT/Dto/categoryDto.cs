using System.ComponentModel.DataAnnotations;

namespace E_COMMERCE_MANAGEMENT.Dto
{
    public class categoryDto
    {
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }


    }
}
