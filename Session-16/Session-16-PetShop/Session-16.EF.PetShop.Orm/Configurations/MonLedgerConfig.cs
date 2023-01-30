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
    public class MonLedgerConfig : IEntityTypeConfiguration<MonthlyLedger>
    {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder)
        {
            builder.HasKey(todo => todo.Year); //Primary key HasKey
           // builder.HasKey(todo => todo.Month);  does this count as a composite key assignment?
           
            builder.Property(todo => todo.Year).ValueGeneratedOnAdd();

            // builder.
            builder.Property(todo => todo.Month).HasMaxLength(15).IsRequired(true);
            builder.Property(todo => todo.Income).HasMaxLength(15).IsRequired(true);
            builder.Property(todo => todo.Expenses).HasMaxLength(15).IsRequired(true);

            builder.Property(todo => todo.Total).HasMaxLength(5).IsRequired(true);
        }
    }
}
