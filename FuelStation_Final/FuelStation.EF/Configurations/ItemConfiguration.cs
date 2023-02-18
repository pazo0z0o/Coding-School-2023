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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");

            // Primary Key
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Code).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(300).IsRequired();
            builder.Property(t => t.ItemType).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Price).HasMaxLength(50).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.Cost).HasMaxLength(50).HasPrecision(10, 2).IsRequired();

            // Relations
        }
    }
}
