using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class DeskDetails
    {
        [Key]
        public int DeskId { get; set; }
        public string DeskStatus { get; set; }

        public ICollection<AllocationDetail> allocationDetails { get; set; }
    }
}