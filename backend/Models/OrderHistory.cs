using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class OrderHistory
    {
        [Key]
        public int Id { set; get; }        
        [Required]
        public string Sender { set; get; }
        [Required]
        public int CustomerId { set; get; }
        public Customer Customer { set; get; }
        [Timestamp]
        public DateTime Date { set; get; }
        public string Remark { set; get; }
        [Required]
        [DefaultValue(1)]
        public int StatusId { set; get; }
        public string Status {
            get
            {
                switch (StatusId)
                {
                    case 1:
                    {
                        return "Checked Out";
                    }
                    case 2:
                    {
                        return "Paid";
                    }
                    default:
                    {
                        return "Error";
                    }

                }
            }

        }

        public List<OrderDetail> OrderDetails { set; get; }
    }
}
