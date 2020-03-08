using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class changeurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/DI/62/2D/00/A8/02/DI622D00A-802@16.jpg?imwidth=300");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg");
        }
    }
}
