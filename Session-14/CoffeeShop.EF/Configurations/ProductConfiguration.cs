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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Id).ValueGeneratedOnAdd();
            builder.Property(product => product.Code).HasMaxLength(50);
            builder.Property(product => product.Description).HasMaxLength(100);
            //builder.Property(product => product.ProductCategoryId);
            builder.Property(product => product.Cost).HasPrecision(10, 2);
            builder.Property(product => product.Price).HasPrecision(10, 2);

            builder.HasOne(product => product.ProductCategory).WithMany(product => product.Products).HasForeignKey(product => product.ProductCategoryId);
        }
    }
}
