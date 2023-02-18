using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace FuelStation.EF.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<TransactionListDTO>
    {
        public void Configure(EntityTypeBuilder<TransactionListDTO> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(t => t.ID);
            builder.Property(t => t.ID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.PaymentMethod).HasMaxLength(15).IsRequired();
            builder.Property(t => t.TotalValue).HasPrecision(10, 2).IsRequired();

            // Relations
            builder
            .HasOne(t => t.Customer)
            .WithMany(c => c.Transactions)
            .HasForeignKey(t => t.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

            builder
           .HasOne(t => t.Employee)
           .WithMany(e => e.Transactions)
           .HasForeignKey(t => t.EmployeeId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
