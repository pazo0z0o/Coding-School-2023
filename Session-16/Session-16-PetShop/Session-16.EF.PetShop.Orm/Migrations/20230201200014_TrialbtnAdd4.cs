using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TrialbtnAdd4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "loaded",
                table: "Transactions");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transactions",
                type: "decimal(10,5)",
                maxLength: 50,
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transactions",
                type: "decimal(10,5)",
                maxLength: 50,
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetFoodPrice",
                table: "Transactions",
                type: "decimal(10,5)",
                maxLength: 50,
                precision: 10,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldMaxLength: 50,
                oldPrecision: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldMaxLength: 50,
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldMaxLength: 50,
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetFoodPrice",
                table: "Transactions",
                type: "decimal(5,2)",
                maxLength: 50,
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,5)",
                oldMaxLength: 50,
                oldPrecision: 10,
                oldScale: 5);

            migrationBuilder.AddColumn<bool>(
                name: "loaded",
                table: "Transactions",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false);
        }
    }
}
