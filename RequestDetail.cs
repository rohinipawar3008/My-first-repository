using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class RequestDetail
    {
        [Key]

        public int RequestId { get; set; }

        [ForeignKey("EmployeeDetails")]

        public int EmployeeId { get; set; }

        public virtual EmployeeDetail employeeDetail { get; set; }

        public string status { get; set; }

        public ICollection<AllocationDetail> allocationDetails { get; set; }

    }
}