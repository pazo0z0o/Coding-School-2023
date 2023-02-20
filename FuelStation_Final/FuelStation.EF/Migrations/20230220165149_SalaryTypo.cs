using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    /// <inheritdoc />
    public partial class SalaryTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SallaryPerMonth",
                table: "Employee",
                newName: "SalaryPerMonth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SalaryPerMonth",
                table: "Employee",
                newName: "SallaryPerMonth");
        }
    }
}
