using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeskAllocation.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("Connection")
        {
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AllocationDetail> AllocationDetails { get; set; }
        public virtual DbSet<DeskDetails> DeskDetails { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<RequestDetail> RequestDetails { get; set; }

        
    }
               
  
}