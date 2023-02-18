using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            // Primary Key
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(50).IsRequired();
            builder.Property(t => t.HireDateStart).HasMaxLength(50).IsRequired();
            builder.Property(t => t.HireDateEnd).HasMaxLength(50); //Did nullable cover this one? Or required
            builder.Property(t => t.SallaryPerMonth).HasMaxLength(50).HasPrecision(10,2).IsRequired();
            builder.Property(t => t.EmployeeType).HasMaxLength(15).IsRequired();


            // Relations
        }
    }
}
