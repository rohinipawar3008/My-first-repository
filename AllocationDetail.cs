using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class AllocationDetail
    {

        [Key]

        public int AllocationId { get; set; }

        [ForeignKey("DeskDetails")]

        public int DeskId { get; set; }

        public virtual DeskDetails deskDetails { get; set; }

        [ForeignKey("requestDetail")]

        public int RequestId { get; set; }

        public virtual RequestDetail requestDetail { get; set; }

    }
}