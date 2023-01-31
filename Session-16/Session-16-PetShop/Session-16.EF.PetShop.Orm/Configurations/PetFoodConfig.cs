using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.EF.Models;

namespace Session_16.EF.PetShop.Orm.Configurations
{
    public class PetFoodConfig : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("Pet Food"); //table name

            builder.HasKey(todo => todo.PetFoodID); //Primary key HasKey
            builder.Property(todo => todo.PetFoodID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(todo => todo.Animaltype).HasMaxLength(15).IsRequired(true);
            
            builder.Property(todo => todo.Price).HasMaxLength(5).HasPrecision(5).IsRequired(true);
            builder.Property(todo => todo.Cost).HasMaxLength(5).HasPrecision(5).IsRequired(true);

            builder.Property(todo => todo.Qty).HasMaxLength(5).IsRequired(true);
            builder.Property(todo => todo.CurrentStock).HasMaxLength(3).IsRequired(true);


        }
    }
}
