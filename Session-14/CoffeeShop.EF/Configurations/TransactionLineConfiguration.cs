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
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("Transaction Line");
            builder.HasKey(transactionLine => transactionLine.Id);
            builder.Property(transactionLine => transactionLine.Id).ValueGeneratedOnAdd();
            builder.Property(transactionLine => transactionLine.ProductId);
            builder.Property(transactionLine => transactionLine.Quantity).IsRequired();
            builder.Property(transactionLine => transactionLine.Price).HasPrecision(10, 2);
            builder.Property(transactionLine => transactionLine.Discount).HasPrecision(10, 2);
            builder.Property(transactionLine => transactionLine.TotalPrice).HasPrecision(10, 2);

            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transactionLine => transactionLine.TransactionLines).HasForeignKey(transactionLine => transactionLine.TransactionId);
            builder.HasOne(transactionLine => transactionLine.Product).WithOne(transactionLine => transactionLine.TransactionLine).HasForeignKey<TransactionLine>(transactionLine => transactionLine.ProductId);
        }
    }
}
