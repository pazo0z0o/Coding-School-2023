using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class PetFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetRep",
                table: "PetRep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthLedger",
                table: "MonthLedger");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeID",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "PetRep",
                type: "int",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PetRep",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "MonthLedger",
                type: "int",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "MonthLedger",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetRep",
                table: "PetRep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthLedger",
                table: "MonthLedger",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transactions",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_EmployeeID",
                table: "Transactions",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetFoodID",
                table: "Transactions",
                column: "PetFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions",
                column: "PetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customers_CustomerID",
                table: "Transactions",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Pet Food_PetFoodID",
                table: "Transactions",
                column: "PetFoodID",
                principalTable: "Pet Food",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Pets_PetID",
                table: "Transactions",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customers_CustomerID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Pet Food_PetFoodID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Pets_PetID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_EmployeeID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetFoodID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetRep",
                table: "PetRep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthLedger",
                table: "MonthLedger");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PetRep");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MonthLedger");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeID",
                table: "Transactions",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "PetRep",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "MonthLedger",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetRep",
                table: "PetRep",
                column: "Year");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthLedger",
                table: "MonthLedger",
                column: "Year");
        }
    }
}
