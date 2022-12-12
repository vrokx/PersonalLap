using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public partial class Order
    {
        [Key]
        public int Orderid { get; set; }

        public DateTime OrderDate { get; set; }
        public float AmountPaid { get; set; }
        public string ModeofPayment { get; set; }
        public string Orderstatus { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        // Navigation Property
         public virtual Cart Cart { get; set; }  
    }
    
}