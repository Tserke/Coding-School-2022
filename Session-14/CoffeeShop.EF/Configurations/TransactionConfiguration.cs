using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop.EF.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.Id);
            builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();
            builder.Property(transaction => transaction.Date);
            //builder.Property(transaction => transaction.EmployeeId);
            //builder.HasAlternateKey(transaction => transaction.CustomerId);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10,2);
            builder.Property(transaction => transaction.PaymentMethod);

            builder.HasOne(transaction => transaction.Customer).WithMany(transaction => transaction.Transactions).HasForeignKey(transaction => transaction.CustomerId);
            builder.HasOne(transaction => transaction.Employee).WithMany(transaction => transaction.Transactions).HasForeignKey(transaction => transaction.EmployeeId);
        }
    }
}
