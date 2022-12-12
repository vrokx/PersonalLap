using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Codefirstapproach.Models
{
    public partial class PreviousOrder
    {
        [ForeignKey("Orders")]
        public int OrderID { get; set;}
        [Key]
        public int PreviousOrderID { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get;set;}

    }
}