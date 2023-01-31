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
    public class PetConfig : IEntityTypeConfiguration<Pet>

    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pets"); //table name

            builder.HasKey(todo => todo.PetID); //Primary key HasKey
            builder.Property(todo => todo.PetID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(todo => todo.Animaltype).HasMaxLength(15).IsRequired(true);
            builder.Property(todo => todo.Petstatus).HasMaxLength(15).IsRequired(true);
            builder.Property(todo => todo.Breed).HasMaxLength(20);
            builder.Property(todo => todo.Price).HasMaxLength(5).HasPrecision(5).IsRequired(true);
            builder.Property(todo => todo.Cost).HasMaxLength(5).HasPrecision(5).IsRequired(true);
   
        
        }
    }
}
