using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            builder.HasKey(trans => trans.TransID); //Primary key HasKey
            builder.Property(trans => trans.TransID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(trans => trans.Date).HasMaxLength(50).IsRequired(true);
           
            builder.Property(trans => trans.PetPrice).HasMaxLength(50).HasPrecision(5).IsRequired(true);     
            builder.Property(trans => trans.PetFoodPrice).HasMaxLength(50).HasPrecision(5).IsRequired(true);
            builder.Property(trans => trans.PetFoodQty).HasMaxLength(50).IsRequired(true);
            builder.Property(trans => trans.TotalPrice).HasMaxLength(50).HasPrecision(5).IsRequired(true);
            builder.Property(trans => trans.loaded).HasMaxLength(50).IsRequired(true);
            // Foreign Keys
            builder.HasOne(trans => trans.Customer)
                 .WithMany(todo => todo.Transacts)
                 .HasForeignKey(trans => trans.CustomerID);
            builder.HasOne(trans => trans.Employee)
                 .WithMany(todo => todo.Transacts)
                 .HasForeignKey(trans => trans.EmployeeID);
            builder.HasOne(trans => trans.Pets)
                 .WithOne(pet => pet.Transacts)
                 .HasForeignKey<Transactions>(trans => trans.PetID);
            
            builder.HasOne(trans => trans.Pfood)
                .WithMany(todo => todo.Transacts)
                .HasForeignKey(trans => trans.PetFoodID);

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
