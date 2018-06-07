using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    
    public class EmployeeContext:DbContext
    {
        public DbSet<EmployeeModel> tableEmployee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VBOLLAM01;Database=Employeetable; Trusted_Connection=True;MultipleActiveResultSets=True; ");
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
