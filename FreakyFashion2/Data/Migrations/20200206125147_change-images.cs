using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class changeimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/AD/12/2O/0A/OQ/11/AD122O0AO-Q11@13.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/C1/42/2O/03/PQ/11/C1422O03P-Q11@8.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/DI/62/2O/02/DC/11/DI622O02D-C11@9.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/LE/22/2O/05/EM/11/LE222O05E-M11@6.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/AD/12/2O/0L/4I/11/AD122O0L4-I11@34.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/TH/34/2D/00/TC/11/TH342D00T-C11@17.jpg?imwidth=300");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/WG/02/1C/0E/6G/11/WG021C0E6-G11@6.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/ZX/12/1C/00/2Q/11/ZX121C002-Q11@11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/1C/09/CQ/11/BEJ21C09C-Q11@15.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/Z1/72/1C/07/GK/11/Z1721C07G-K11@3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/outfit-image-mhq/53d1874b9e594f3bb8f8b9d7096f9f45/19b5700ddf7c4f94998ea439a9bd8868.jpeg?imwidth=600");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-");
        }
    }
}
