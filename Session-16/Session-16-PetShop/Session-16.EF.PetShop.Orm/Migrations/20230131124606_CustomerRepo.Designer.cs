﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session_16.EF.PetShop.Orm.Context;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230131124606_CustomerRepo")]
    partial class CustomerRepo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Session_16.EF.Models.Customers", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TIN")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Session_16.EF.Models.Employees", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmpSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EmpType")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("SalaryPerMonth")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Session_16.EF.Models.MonthlyLedger", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Expenses")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("Income")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Month")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MonthLedger");
                });

            modelBuilder.Entity("Session_16.EF.Models.Pet", b =>
                {
                    b.Property<Guid>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animaltype")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Cost")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Petstatus")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("PetID");

                    b.ToTable("Pets", (string)null);
                });

            modelBuilder.Entity("Session_16.EF.Models.PetFood", b =>
                {
                    b.Property<Guid>("PetFoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animaltype")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("CurrentStock")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("Qty")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PetFoodID");

                    b.ToTable("Pet Food", (string)null);
                });

            modelBuilder.Entity("Session_16.EF.Models.PetReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animal")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal>("TotalSold")
                        .HasMaxLength(5)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PetRep");
                });

            modelBuilder.Entity("Session_16.EF.Models.Transactions", b =>
                {
                    b.Property<Guid?>("TransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PetFoodID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PetFoodPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("PetFoodQty")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("PetID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PetPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("TotalPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool>("loaded")
                        .HasMaxLength(50)
                        .HasColumnType("bit");

                    b.HasKey("TransID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PetFoodID");

                    b.HasIndex("PetID");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("Session_16.EF.Models.Transactions", b =>
                {
                    b.HasOne("Session_16.EF.Models.Customers", "Customer")
                        .WithMany("Transacts")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session_16.EF.Models.Employees", "Employee")
                        .WithMany("Transacts")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session_16.EF.Models.PetFood", "Pfood")
                        .WithMany("Transacts")
                        .HasForeignKey("PetFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session_16.EF.Models.Pet", "Pets")
                        .WithMany("Transacts")
                        .HasForeignKey("PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Pets");

                    b.Navigation("Pfood");
                });

            modelBuilder.Entity("Session_16.EF.Models.Customers", b =>
                {
                    b.Navigation("Transacts");
                });

            modelBuilder.Entity("Session_16.EF.Models.Employees", b =>
                {
                    b.Navigation("Transacts");
                });

            modelBuilder.Entity("Session_16.EF.Models.Pet", b =>
                {
                    b.Navigation("Transacts");
                });

            modelBuilder.Entity("Session_16.EF.Models.PetFood", b =>
                {
                    b.Navigation("Transacts");
                });
#pragma warning restore 612, 618
        }
    }
}
