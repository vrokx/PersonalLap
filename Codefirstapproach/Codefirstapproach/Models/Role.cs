using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public partial class Role
    {
        [Key]
        public int UsertypeId { get; set; }
        [Required]
        public string UsertypeName { get; set; }

    }
}