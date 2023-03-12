using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.EF.Migrations
{
    /// <inheritdoc />
    public partial class Corrections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "Transactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetId",
                table: "Transactions",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");
        }
    }
}
