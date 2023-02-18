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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(50).IsRequired();
            builder.Property(t => t.CardNumber).HasMaxLength(20).IsRequired();        

            // Relations

        }
    }
}
