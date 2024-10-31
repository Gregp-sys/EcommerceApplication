using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueForTotalPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total_price",
                table: "ShoppingSessions",
                nullable: false,
                defaultValue: 0m);  // Sets default to 0
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total_price",
                table: "ShoppingSessions",
                nullable: false,
                defaultValue: null);
        }
    }
}
