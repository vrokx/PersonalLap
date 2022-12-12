using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public float Totalamount { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        //Navigation Propertie
        public virtual Product Products { get; set; }
        public virtual User User { get; set; }
        public virtual Wallet Wallet { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}