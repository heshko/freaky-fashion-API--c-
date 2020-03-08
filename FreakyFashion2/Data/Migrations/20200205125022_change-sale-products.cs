using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class changesaleproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "ProductId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "ProductId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "ProductId",
                value: 24);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "ProductId",
                value: 5);
        }
    }
}
