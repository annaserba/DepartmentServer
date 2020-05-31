using System;
using System.Collections.Generic;
using System.Text;
using DepartmentServer.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
    }
}
