using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.EF.PetShop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TransRepo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions",
                column: "PetID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetID",
                table: "Transactions",
                column: "PetID");
        }
    }
}
