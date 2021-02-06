using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Customer
    {
        [Key]
        public int Id { set; get; }
        [Required]
        [MaxLength(16)]
        public string Name { set; get; }
        [Required]
        [MaxLength(255)]
        public string Address { set; get; }
    }
}
