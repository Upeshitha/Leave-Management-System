using Employee_Leave_Managent.Data.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Employee_Leave_Managent.Models;

namespace Employee_Leave_Managent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<Employee_Leave_Managent.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        public DbSet<Employee_Leave_Managent.Models.EmployeeVM> EmployeeVM { get; set; }
    }
}
