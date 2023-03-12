using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configurations
{
    public class TransactionLineConfig : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            // Table Name
            builder.ToTable("TransactionLines");

            // Primary Key
            builder.HasKey(tl => tl.Id);
            builder.Property(tl => tl.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(tl => tl.AnimalType).IsRequired();
            builder.Property(tl => tl.PetFoodQuality).IsRequired();
            builder.Property(tl => tl.PetFoodPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(tl => tl.Quantity).IsRequired();
            builder.Property(tl => tl.PetPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(tl => tl.PetBreed).HasMaxLength(50).IsRequired();

            // Relations
            builder.HasOne(tl => tl.Transaction)
                .WithMany(tl => tl.TransactionLines)
                .HasForeignKey(tl => tl.TransactionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(tl => tl.Pet)
                .WithOne(pt => pt.TransactionLines)
                .HasForeignKey<TransactionLine>(tl => tl.PetId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(tl => tl.PetFood)
                .WithMany(tl => tl.TransactionLines)
                .HasForeignKey(tl => tl.PetFoodId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
