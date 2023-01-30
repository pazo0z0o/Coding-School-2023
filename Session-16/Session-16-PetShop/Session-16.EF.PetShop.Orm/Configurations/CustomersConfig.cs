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
    public class CustomersConfig : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("Customers"); //table name

            builder.HasKey(todo => todo.CustomerID); //Primary key HasKey
            builder.Property(todo => todo.CustomerID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(todo => todo.Name).HasMaxLength(50);
            builder.Property(todo => todo.Surname).HasMaxLength(50);
            builder.Property(todo => todo.Phone).HasMaxLength(10);
            builder.Property(todo => todo.TIN).HasMaxLength(12).IsRequired(true);


        }
    }
}
