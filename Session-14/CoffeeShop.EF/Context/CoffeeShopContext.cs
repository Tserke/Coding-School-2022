using CoffeeShop.EF.Configurations;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Context
{
    public class CoffeeShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

        }
          

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source=DESKTOP-LDBKGMR\SQLEXPRESS;Initial Catalog=LocalDbSession-14; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
