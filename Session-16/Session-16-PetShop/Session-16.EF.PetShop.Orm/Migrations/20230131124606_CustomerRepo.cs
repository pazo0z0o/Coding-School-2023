using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class CustomerRepo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetFoodPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pets",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pets",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSold",
                table: "PetRep",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pet Food",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pet Food",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "MonthLedger",
                type: "decimal(5,2)",
                maxLength: 15,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<decimal>(
                name: "Expenses",
                table: "MonthLedger",
                type: "decimal(5,2)",
                maxLength: 15,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryPerMonth",
                table: "Employees",
                type: "decimal(5,2)",
                maxLength: 5,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transactions",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transactions",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetFoodPrice",
                table: "Transactions",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pets",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pets",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSold",
                table: "PetRep",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pet Food",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pet Food",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "MonthLedger",
                type: "decimal(18,2)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 15,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Expenses",
                table: "MonthLedger",
                type: "decimal(18,2)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 15,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryPerMonth",
                table: "Employees",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 5,
                oldPrecision: 5);
        }
    }
}
