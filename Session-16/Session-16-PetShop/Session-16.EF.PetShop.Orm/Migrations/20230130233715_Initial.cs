using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TIN = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpType = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    SalaryPerMonth = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MonthLedger",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", maxLength: 15, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthLedger", x => x.Year);
                });

            migrationBuilder.CreateTable(
                name: "Pet Food",
                columns: table => new
                {
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Animaltype = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    CurrentStock = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet Food", x => x.PetFoodID);
                });

            migrationBuilder.CreateTable(
                name: "PetRep",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Animal = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    TotalSold = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetRep", x => x.Year);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Animaltype = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Petstatus = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetFoodQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    loaded = table.Column<bool>(type: "bit", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "MonthLedger");

            migrationBuilder.DropTable(
                name: "Pet Food");

            migrationBuilder.DropTable(
                name: "PetRep");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
