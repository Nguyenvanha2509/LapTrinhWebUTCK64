using Day05Lab.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Day05Lab.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Bảng Employees trong database
        public DbSet<Employee> Employees { get; set; }
    }
}
