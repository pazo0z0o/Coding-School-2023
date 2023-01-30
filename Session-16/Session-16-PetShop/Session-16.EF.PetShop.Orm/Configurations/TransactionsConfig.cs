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
    public class TransactionsConfig : IEntityTypeConfiguration<Transactions>
    {
    
public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions"); //table name

            builder.HasKey(todo => todo.TransID); //Primary key HasKey
            builder.Property(todo => todo.TransID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(todo => todo.Date).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.CustomerID).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.EmployeeID).HasMaxLength(50);
           
            builder.Property(todo => todo.PetID).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.PetPrice).HasMaxLength(50).IsRequired(true);
                 
            builder.Property(todo => todo.PetFoodID).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.PetFoodPrice).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.PetFoodQty).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.TotalPrice).HasMaxLength(50).IsRequired(true);
            builder.Property(todo => todo.loaded).HasMaxLength(50).IsRequired(true);



        }
    }
}


/*public Guid? TransID { get; set; }
public DateTime Date { get; set; }
public Guid CustomerID { get; set; }
public Guid? EmployeeID { get; set; }
public Guid? PetID { get; set; }
public decimal? PetPrice { get; set; }
public Guid? PetFoodID { get; set; }
public decimal PetFoodQty { get; set; }
public decimal? PetFoodPrice { get; set; }
public decimal? TotalPrice { get; set; }
//private bool _loaded = false;*/
