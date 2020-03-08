using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class fixerurlsulgUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImgUrl", "UrlSlug" },
                values: new object[] { "https://www.jackjones.com/dw/image/v2/ABBT_PRD/on/demandware.static/-/Library-Sites-bestseller-content-library/default/dw60c35ca7/jackjones/store-assets/2020/w06/update1/category-banner/bp1_trousers-row1-box1-sv-se.jpg?sw=660", "Trouthers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImgUrl", "UrlSlug" },
                values: new object[] { "https://bigtamfitness.com/wp-content/uploads/2018/01/tshirts-category.jpg", "T-Shirts" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImgUrl", "UrlSlug" },
                values: new object[] { "https://www.eshakti.com/images/Categorybanner_Dresses.jpg?v=65", "Dresses" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImgUrl", "UrlSlug" },
                values: new object[] { "https://designtorget.se/media/catalog/category/Kategorisida_Mellandags-rea_70_DT_1.jpg", "Sale" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UrlSlug" },
                values: new object[] { "Tygbyxor-g", "Tygbyxor-g" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UrlSlug",
                table: "Products",
                column: "UrlSlug",
                unique: true,
                filter: "[UrlSlug] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_UrlSlug",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UrlSlug" },
                values: new object[] { "Tygbyxor", "Tygbyxor" });
        }
    }
}
