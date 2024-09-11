using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SalesDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<Sale> Sales {  get; set; }
        public DbSet<Store> Stores {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = . ;Integrated Security = True ;TrustServerCertificate= True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Product
            modelBuilder.Entity<Product>()
                .Property(x => x.Name)
                .HasColumnType("nvarchar(50)");

            modelBuilder.Entity<Product>()
                .Property(p => p.Quantity)
                .HasColumnType("real");
            // Customer
            modelBuilder.Entity<Customer>()
                .Property(o => o.Name)
                .HasColumnType("nvarchar(100)");

            modelBuilder.Entity<Customer>()
                .Property(i => i.Email)
                .HasColumnType("nvarchar(80)");
            // Store
            modelBuilder.Entity<Store>()
                .Property(x => x.Name)
                .HasColumnType("nvarchar(80)");

        }

    }
}
