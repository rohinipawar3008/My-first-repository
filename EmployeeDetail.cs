using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

       public ICollection<RequestDetail> requestDetails { get; set; }
    }
}