using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class changeimagev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QK/12/BEJ22G02Q-K12@14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/M9/12/2G/0F/3K/11/M9122G0F3-K11@14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/PK/11/BEJ22G02P-K11@6.2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OQ/11/BEJ22G02O-Q11@2.1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/GS/12/2G/0M/ZK/11/GS122G0MZ-K11@18.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OK/12/BEJ22G02O-K12@10.1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QQ/11/BEJ22G02Q-Q11@10.1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://mosaic04.ztat.net/vgs/media/catalog-sm/WG/02/1C/0B/PM/11/WG021C0BP-M11@18.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=1800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg");
        }
    }
}
