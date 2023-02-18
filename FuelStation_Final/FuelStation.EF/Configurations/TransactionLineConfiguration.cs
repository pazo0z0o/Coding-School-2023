using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");

            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Quantity).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.ItemPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.NetValue).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.DiscountPercent).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.DiscountValue).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.TotalValue).HasPrecision(10, 2).IsRequired();

            // Relations
            builder
           .HasOne(tl => tl.Transaction)
           .WithMany(t => t.TransactionLines)
           .HasForeignKey(tl => tl.TransactionID)
           .OnDelete(DeleteBehavior.Cascade);

            builder
           .HasOne(tl => tl.Item)
           .WithMany(i => i.TransactionLines)
           .HasForeignKey(tl => tl.ItemID)
           .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
