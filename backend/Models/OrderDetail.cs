using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public int OrderId { set; get; }
        public OrderHistory Order { set; get; }
        [Required]
        public int ProductId { set; get; }
        public Product Product { set; get; }
        [Required]
        [DefaultValue(0)]
        public int Qty { set; get; }
        [NotMapped]
        public int Total 
        { 
            get
            { 
                return Product.Price * Qty;
            }
        }
    }
}
