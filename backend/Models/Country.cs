using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Country
    {
        [Key]
        public int Id { set; get; }
        [Required]
        [MaxLength(16)]
        public string Name { set; get; }
        [Required]
        [MaxLength(16)]
        public string Currency { set; get; }
        [Required]
        [MaxLength(3)]
        public string Symbol { set; get; }
    }
}
