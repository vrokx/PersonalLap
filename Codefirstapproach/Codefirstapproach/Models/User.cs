using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Mobile_no { get; set; }
        //public DateOnly DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [ForeignKey("Role")]
        public int UsertypeId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        // Navigation Properties
        public virtual Role Role { get; set; } 
        public virtual ICollection<Product> Products { get; set;}
        public virtual Wallet Wallet { get; set; }  
        public virtual ICollection<PreviousOrder> Previousoreders { get; set; }
        public virtual Cart Cart { get;}

    }
}