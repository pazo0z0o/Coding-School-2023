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
    public class EmployeesConfig : IEntityTypeConfiguration<Employees>
    { 
    
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.ToTable("Employees"); //table name

            builder.HasKey(todo => todo.EmployeeID); //Primary key HasKey
            builder.Property(todo => todo.EmployeeID).ValueGeneratedOnAdd();
            // builder.
            builder.Property(todo => todo.EmpName).HasMaxLength(50);
            builder.Property(todo => todo.EmpSurname).HasMaxLength(50);
            builder.Property(todo => todo.EmpType).HasMaxLength(10);
            builder.Property(todo => todo.SalaryPerMonth).HasMaxLength(5).IsRequired(true);
        }
    }
}
