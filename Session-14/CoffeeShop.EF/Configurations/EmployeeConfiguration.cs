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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(employee => employee.Id);
            builder.Property(employee => employee.Id).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(100);
            builder.Property(employee => employee.Surname).HasMaxLength(100);
            builder.Property(employee => employee.EmployeeType).IsRequired(true);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(10, 2);

        }
    }
}
