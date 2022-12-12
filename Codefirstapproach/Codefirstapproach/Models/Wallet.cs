using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public partial class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
        public int CurrentBalance {get;set;}
        //Navigation Properties
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual User User { get; set; }



    }
}