using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyFirstEfCoreProject.Model;

namespace MyFirstEfCoreProject
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=electronic.db");
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
