using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class changeimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/PO/22/2O/03/FC/14/PO222O03F-C14@3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/GS/12/2G/0M/ZK/11/GS122G0MZ-K11@18.jpg");
        }
    }
}
