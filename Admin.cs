using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class Admin
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}