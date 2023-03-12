using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.EF.Migrations
{
    /// <inheritdoc />
    public partial class MoreChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_PetFoods_PetFoodId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PetFoodId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetFoodId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetFoodPrice",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetFoodQty",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetFoodQuality",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PetPrice",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Transactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetFoodQuality = table.Column<int>(type: "int", nullable: false),
                    StockFoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_PetFoods_StockFoodId",
                        column: x => x.StockFoodId,
                        principalTable: "PetFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PetFoodQuality = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PetBreed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    PetFoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionLines_PetFoods_PetFoodId",
                        column: x => x.PetFoodId,
                        principalTable: "PetFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionLines_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionLines_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stock_StockFoodId",
                table: "Stock",
                column: "StockFoodId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_PetFoodId",
                table: "TransactionLines",
                column: "PetFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_PetId",
                table: "TransactionLines",
                column: "PetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_TransactionId",
                table: "TransactionLines",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "TransactionLines");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetFoodId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PetFoodPrice",
                table: "Transactions",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PetFoodQty",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PetFoodQuality",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PetPrice",
                table: "Transactions",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PetFoodId",
                table: "Transactions",
                column: "PetFoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_PetFoods_PetFoodId",
                table: "Transactions",
                column: "PetFoodId",
                principalTable: "PetFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Pets_PetId",
                table: "Transactions",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
