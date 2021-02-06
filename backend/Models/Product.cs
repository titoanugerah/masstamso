using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        [Required]
        [MaxLength(16)]
        public string Name { set; get; }
        [Required]
        public int Price { set; get; }
    }
}
