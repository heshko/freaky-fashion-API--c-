using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion2.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProductNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Trouthers" },
                    { 2, "Shirts" },
                    { 3, "Dresses" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "ProductNumber" },
                values: new object[,]
                {
                    { 22, "Material: 100% polyester", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=", "CETO DRAWSTRING", 300f, "dsadaw22da" },
                    { 21, "Material: 100% polyester", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=", "AMARIS LONG KIMONO", 2000f, "12099812" },
                    { 20, "Material: 100% polyester", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=", "VALENTINA DRESS - Skjortklänning", 400f, "1231099212" },
                    { 19, "Material: 100% viskos", "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg", "GILLEA - Skjortklänning", 1200f, "123000989" },
                    { 18, "Material: 100% viskos", "https://photo.venus.com/im/18062700.jpg?preset=product", "MNIA DRESS", 200f, "1231321" },
                    { 17, "Material: 100% viskos", "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475", "TAMAYO DRESS", 900f, "1221312131321" },
                    { 16, "MATERIAL & SKÖTSEL", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN", "CAMBRIDGE - Piké", 300f, "312312" },
                    { 15, "Material: 100% bomull", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg", "GEO ALL - Piké", 200f, "12313299901" },
                    { 14, "Material: 100% bomull", "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png", "BASIC 2 PACK - Piké", 700f, "989912002" },
                    { 13, "Material: 100% bomull", "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium", "Piké", 400f, "12313212131" },
                    { 12, "Material: 60% bomull, 40% polyester", "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg", "Sweatshirt", 200f, "1231320091" },
                    { 11, "Material: 100% bomull", "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg", "CHECK - Piké", 190f, "00976152" },
                    { 10, "Material: 100% bomull", "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2", "FLORAL PANEL - Piké", 100f, "00987712" },
                    { 9, "Material: 100% bomull", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg", "Piké", 700f, "10098" },
                    { 8, "Material: 97% bomull, 3% elastanr", "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$", "Tygbyxor", 200f, "12329980" },
                    { 7, "Material: 84% polyester, 15% viskos, 1% elastan", "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg", "Tygbyxor-b", 200f, "123990" },
                    { 6, "Material: 100% bomull", "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg", "Tygbyxor", 400f, "1231241" },
                    { 5, "Material: 79% bomull, 21% polyester", "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg", "TAPE PANTS", 700f, "132213" },
                    { 4, "Material: 90% polyester, 10% elastan", "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg", "FLEX WOVEN", 200f, "132213" },
                    { 3, "Material: Best Byxor", "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762", "HYBRID PANT", 400f, "11231234" },
                    { 2, "Material: Material: 100% polyester", "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762", "TRAIN LOGO PANT", 400f, "12343211234" },
                    { 1, "Material: 98% bomull, 2% elastan", "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=1800", "Chinos", 300f, "12343211234" },
                    { 23, "Material: 100% viskos", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=", "NINGBOX - Skjortklänning", 400f, "89761125" },
                    { 24, "Material: 100% viskos", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-", "PCNICOLETTA DRESS - Skjortklänning", 1500f, "200918" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 22, 3, 22 },
                    { 21, 3, 21 },
                    { 20, 3, 20 },
                    { 19, 3, 19 },
                    { 18, 3, 18 },
                    { 17, 3, 17 },
                    { 16, 2, 16 },
                    { 15, 2, 15 },
                    { 14, 2, 14 },
                    { 13, 2, 13 },
                    { 12, 2, 12 },
                    { 11, 2, 11 },
                    { 10, 2, 10 },
                    { 9, 2, 9 },
                    { 8, 1, 8 },
                    { 7, 1, 7 },
                    { 6, 1, 6 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 23, 3, 23 },
                    { 24, 3, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
