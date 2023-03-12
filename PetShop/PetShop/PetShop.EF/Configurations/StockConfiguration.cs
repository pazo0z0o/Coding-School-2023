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
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            // Table Name
            builder.ToTable("Stock");

            // Primary Key
            builder.HasKey(stock => stock.Id);
            builder.Property(stock => stock.Id).ValueGeneratedOnAdd();

            builder.Property(stock => stock.AnimalType).IsRequired();
            builder.Property(stock => stock.PetFoodQuality).IsRequired();
            builder.Property(stock => stock.StockQuantity).IsRequired();
            builder.Property(stock => stock.StockQuantity).IsRequired();
            builder.Property(stock => stock.StockQuantity).IsRequired();

            builder.HasOne(stock => stock.PetFoods)
                .WithOne(pf => pf.Stock)
                .HasForeignKey<Stock>(stock => stock.StockFoodId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        
    }
}
