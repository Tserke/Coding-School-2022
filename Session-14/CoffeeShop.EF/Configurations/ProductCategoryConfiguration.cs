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
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("Product Category");
            builder.HasKey(category => category.Id);
            builder.Property(category => category.Id).ValueGeneratedOnAdd();
            builder.Property(category => category.Code).HasMaxLength(100);
            builder.Property(category => category.Description).HasMaxLength(100);
            builder.Property(category => category.ProductType).IsRequired(true);
        }
    }
}
