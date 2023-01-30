﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.EF.Models;

namespace Session_16.EF.PetShop.Orm.Configurations
{
    public class PetReportConfig : IEntityTypeConfiguration<PetReport>
    {
        public void Configure(EntityTypeBuilder<PetReport> builder)
        {
            builder.HasKey(todo => todo.Year); //Primary key HasKey
           // builder.HasKey(todo => todo.Month); 
            builder.Property(todo => todo.Year).ValueGeneratedOnAdd();
          
            // builder.
            builder.Property(todo => todo.Month).HasMaxLength(15).IsRequired(true);
            builder.Property(todo => todo.Animal).HasMaxLength(15).IsRequired(true);

            builder.Property(todo => todo.TotalSold).HasMaxLength(5).IsRequired(true);
            
        }
    }
}

/*
[Key, Column(Order = 0)]
public int MyFirstKeyProperty { get; set; }

[Key, Column(Order = 1)]
public int MySecondKeyProperty { get; set; }*/