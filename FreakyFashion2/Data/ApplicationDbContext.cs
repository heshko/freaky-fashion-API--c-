using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Order> Orders { get; set; }
    
        public DbSet<User> User { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasIndex(x => x.UrlSlug).IsUnique();
            builder.Entity<Product>().HasData(

                new Product
                {
                    Id=1,
                    Name= "Chinos",
                    Description= "Material: 98% bomull, 2% elastan",
                    ProductNumber="02343211234",
                    ImageUrl= "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QK/12/BEJ22G02Q-K12@14.jpg",
                    Price = 300,
                    UrlSlug= "Chinos"

                },
                 new Product
                 {
                     Id = 2,
                     Name = "TRAIN LOGO PANT",
                     Description = "Material: Material: 100% polyester",
                     ProductNumber = "02343211234",
                     ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/M9/12/2G/0F/3K/11/M9122G0F3-K11@14.jpg",
                     Price = 400,
                     UrlSlug= "TRAIN-LOGO-PANT"

                 },
                 new Product
                    {
                        Id = 3,
                        Name = "HYBRID PANT",
                        Description = "Material: Best Byxor",
                        ProductNumber = "01231234",
                        ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/PK/11/BEJ22G02P-K11@6.2.jpg",
                        Price = 400,
                        UrlSlug= "HYBRID-PANT"

                 },
                 new Product
                  {
                      Id = 4,
                      Name = "FLEX WOVEN",
                      Description = "Material: 90% polyester, 10% elastan",
                      ProductNumber = "032213",
                      ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OQ/11/BEJ22G02O-Q11@2.1.jpg",
                      Price = 200,
                     UrlSlug= "FLEX-WOVEN"
                 },
                 new Product
                   {
                       Id = 5,
                       Name = "TAPE PANTS",
                       Description = "Material: 79% bomull, 21% polyester",
                       ProductNumber = "032213",
                       ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/PO/22/2O/03/FC/14/PO222O03F-C14@3.jpg",
                       Price = 700,
                      UrlSlug = "TAPE-PANTS"
                 },
                    new Product
                    {
                        Id = 6,
                        Name = "Tygbyxor",
                        Description = "Material: 100% bomull",
                        ProductNumber="0231241",
                        ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OK/12/BEJ22G02O-K12@10.1.jpg",
                        Price = 400,
                        UrlSlug = "Tygbyxor"
                    },
                     new Product
                     {
                         Id = 7,
                         Name = "Tygbyxor-b",
                         Description = "Material: 84% polyester, 15% viskos, 1% elastan",
                         ProductNumber="023990",
                         ImageUrl = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg",
                         Price = 200,
                         UrlSlug = "Tygbyxor-b"
                     },
                      new Product
                      {
                          Id = 8,
                          Name = "Tygbyxor-g",
                          Description = "Material: 97% bomull, 3% elastanr",
                          ProductNumber = "02329980",
                          ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QQ/11/BEJ22G02Q-Q11@10.1.jpg",
                          Price = 200,
                          UrlSlug = "Tygbyxor-g"
                      },
                       new Product
                       {
                           Id = 9,
                           Name = "Piké-22",
                           Description = "Material: 100% bomull",
                          ProductNumber="10098",
                           ImageUrl = "https://img01.ztat.net/article/DI/62/2D/00/A8/02/DI622D00A-802@16.jpg?imwidth=300",
                           Price = 700,
                           UrlSlug = "Piké-22"
                       },
                        new Product
                        {
                            Id = 10,
                            Name = "FLORAL PANEL - Piké",
                            Description = "Material: 100% bomull",
                           ProductNumber="10987712",
                            ImageUrl = "https://img01.ztat.net/article/AD/12/2O/0A/OQ/11/AD122O0AO-Q11@13.jpg?imwidth=300",
                            Price = 100,
                            UrlSlug = "FLORAL-PANEL-Piké"
                        },
                          new Product
                          {
                              Id = 11,
                              Name = "CHECK - Piké",
                              Description = "Material: 100% bomull",
                             ProductNumber="10976152",
                              ImageUrl = "https://img01.ztat.net/article/C1/42/2O/03/PQ/11/C1422O03P-Q11@8.jpg?imwidth=300",
                              Price = 190,
                              UrlSlug = "CHECK-Piké"
                          },
                            new Product
                            {
                                Id = 12,
                                Name = "Sweatshirt",
                                Description = "Material: 60% bomull, 40% polyester",
                                ProductNumber = "1231320091",
                                ImageUrl = "https://img01.ztat.net/article/DI/62/2O/02/DC/11/DI622O02D-C11@9.jpg?imwidth=300",
                                Price = 200,
                                UrlSlug = "Sweatshirt"
                            },
                              new Product
                              {
                                  Id = 13,
                                  Name = "pp-Piké",
                                  Description = "Material: 100% bomull",
                                  ProductNumber = "12313212131",
                                  ImageUrl = "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium",
                                  Price = 400,
                                  UrlSlug = "pp-Piké"
                              },
                                new Product
                                {
                                    Id = 14,
                                    Name = "BASIC 2 PACK - Piké",
                                    Description = "Material: 100% bomull",
                                    ProductNumber = "189912002",
                                    ImageUrl = "https://img01.ztat.net/article/LE/22/2O/05/EM/11/LE222O05E-M11@6.jpg?imwidth=300",
                                    Price = 700,
                                    UrlSlug = "BASIC-2-PACK-Piké"
                                },
                                  new Product
                                  {
                                      Id = 15,
                                      Name = "GEO ALL - Piké",
                                      Description = "Material: 100% bomull",
                                      ProductNumber = "12313299901",
                                      ImageUrl = "https://img01.ztat.net/article/AD/12/2O/0L/4I/11/AD122O0L4-I11@34.jpg?imwidth=300",
                                      Price = 200,
                                      UrlSlug = "GEO-ALL-Piké"
                                  },
                                   new Product
                                   {
                                       Id = 16,
                                       Name = "CAMBRIDGE - Piké",
                                       Description = "MATERIAL & SKÖTSEL",
                                       ProductNumber = "112312",
                                       ImageUrl = "https://img01.ztat.net/article/TH/34/2D/00/TC/11/TH342D00T-C11@17.jpg?imwidth=300",
                                       Price = 300,
                                       UrlSlug= "CAMBRIDGE-Piké"

                                   },
                                   new Product
                                   {
                                       Id = 17,
                                       Name = "TAMAYO DRESS",
                                       Description = "Material: 100% viskos",
                                       ProductNumber = "2221312131321",
                                       ImageUrl = "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475",
                                       Price = 900,
                                       UrlSlug = "TAMAYO-DRESS"
                                   },
                                    new Product
                                    {
                                        Id = 18,
                                        Name = "MNIA DRESS",
                                        Description = "Material: 100% viskos",
                                        ProductNumber = "2231321",
                                        ImageUrl = "https://photo.venus.com/im/18062700.jpg?preset=product",
                                        Price = 200,
                                        UrlSlug = "MNIA-DRESS"
                                    },
                                     new Product
                                     {
                                         Id = 19,
                                         Name = "GILLEA - Skjortklänning",
                                         Description = "Material: 100% viskos",
                                         ProductNumber = "223000989",
                                         ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/WG/02/1C/0B/PM/11/WG021C0BP-M11@18.jpg",
                                         Price = 1200,
                                         UrlSlug = "GILLEA-Skjortklänning"
                                     },
                                      new Product
                                      {
                                          Id = 20,
                                          Name = "VALENTINA DRESS - Skjortklänning",
                                          Description = "Material: 100% polyester",
                                          ProductNumber = "2231099212",
                                          ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/WG/02/1C/0E/6G/11/WG021C0E6-G11@6.jpg",
                                          Price = 400,
                                          UrlSlug = "VALENTINA-DRESS-Skjortklänning"
                                      },
                                        new Product
                                        {
                                            Id = 21,
                                            Name = "AMARIS LONG KIMONO",
                                            Description = "Material: 100% polyester",
                                            ProductNumber = "22099812",
                                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/ZX/12/1C/00/2Q/11/ZX121C002-Q11@11.jpg",
                                            Price = 2000,
                                            UrlSlug = "AMARIS-LONG-KIMONO"
                                        },
                                        new Product
                                        {
                                            Id = 22,
                                            Name = "CETO DRAWSTRING",
                                            Description = "Material: 100% polyester",
                                            ProductNumber = "209990",
                                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/1C/09/CQ/11/BEJ21C09C-Q11@15.jpg",
                                            Price = 300,
                                            UrlSlug = "CETO-DRAWSTRING"
                                        },
                                        new Product
                                        {
                                            Id = 23,
                                            Name = "NINGBOX - Skjortklänning",
                                            Description = "Material: 100% viskos",
                                            ProductNumber = "29761125",
                                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/Z1/72/1C/07/GK/11/Z1721C07G-K11@3.jpg",
                                            Price = 400,
                                            UrlSlug = "NINGBOX-Skjortklänning"
                                        },
                                        new Product
                                        {
                                            Id = 24,
                                            Name = "PCNICOLETTA DRESS - Skjortklänning",
                                            Description = "Material: 100% viskos",
                                            ProductNumber = "200918",
                                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/outfit-image-mhq/53d1874b9e594f3bb8f8b9d7096f9f45/19b5700ddf7c4f94998ea439a9bd8868.jpeg?imwidth=600",
                                            Price = 1500,
                                            UrlSlug = "PCNICOLETTA-DRESS-Skjortklänning"
                                        }
                                       
                );
            builder.Entity<Category>().HasData(

                         new Category { Id = 1,Name="Trouthers",UrlSlug= "Trouthers",
                        ImgUrl= "https://www.jackjones.com/dw/image/v2/ABBT_PRD/on/demandware.static/-/Library-Sites-bestseller-content-library/default/dw60c35ca7/jackjones/store-assets/2020/w06/update1/category-banner/bp1_trousers-row1-box1-sv-se.jpg?sw=660" }  ,
                         new Category { Id = 2, Name = "T-Shirts",UrlSlug= "T-Shirts",
                         ImgUrl= "https://bigtamfitness.com/wp-content/uploads/2018/01/tshirts-category.jpg"
                         },
                         new Category { Id = 3, Name = "Dresses",UrlSlug = "Dresses" 
                         ,ImgUrl= "https://www.eshakti.com/images/Categorybanner_Dresses.jpg?v=65"
                         },
                         new Category { Id = 4, Name = "Sale",UrlSlug= "Sale",
                         ImgUrl= "https://designtorget.se/media/catalog/category/Kategorisida_Mellandags-rea_70_DT_1.jpg"
                         }
                );
            builder.Entity<ProductCategory>().HasData(

                       new ProductCategory { Id = 1, ProductId=1, CategoryId = 1},
                       new ProductCategory { Id = 2, ProductId = 2, CategoryId = 1 },
                       new ProductCategory { Id = 3, ProductId = 3, CategoryId = 1 },
                       new ProductCategory { Id = 4, ProductId =4, CategoryId = 1 },
                       new ProductCategory { Id = 5, ProductId = 5, CategoryId = 1 },
                       new ProductCategory { Id = 6, ProductId = 6, CategoryId = 1 },
                       new ProductCategory { Id = 7, ProductId = 7, CategoryId = 1 },
                       new ProductCategory { Id = 8, ProductId = 8, CategoryId = 1 },

                       new ProductCategory { Id = 9, ProductId = 9, CategoryId = 2 },
                       new ProductCategory { Id = 10, ProductId = 10, CategoryId = 2 },
                       new ProductCategory { Id = 11, ProductId = 11, CategoryId = 2 },
                       new ProductCategory { Id = 12, ProductId = 12, CategoryId = 2 },
                       new ProductCategory { Id = 13, ProductId = 13, CategoryId = 2 },
                       new ProductCategory { Id = 14, ProductId = 14, CategoryId = 2 },
                       new ProductCategory { Id = 15, ProductId = 15, CategoryId = 2 },
                       new ProductCategory { Id = 16, ProductId = 16, CategoryId = 2 },

                       new ProductCategory { Id = 17, ProductId = 17, CategoryId = 3 },
                       new ProductCategory { Id = 18, ProductId = 18, CategoryId = 3 },
                       new ProductCategory { Id = 19, ProductId = 19, CategoryId = 3 },
                       new ProductCategory { Id = 20, ProductId = 20, CategoryId = 3 },
                       new ProductCategory { Id = 21, ProductId = 21, CategoryId = 3 },
                       new ProductCategory { Id = 22, ProductId = 22, CategoryId = 3 },
                       new ProductCategory { Id = 23, ProductId = 23, CategoryId = 3 },
                       new ProductCategory { Id = 24, ProductId = 24, CategoryId = 3 },

                       new ProductCategory { Id = 25, ProductId = 1, CategoryId = 4 },
                       new ProductCategory { Id = 26, ProductId = 12, CategoryId = 4 },
                       new ProductCategory { Id = 27, ProductId = 8, CategoryId = 4 },
                       new ProductCategory { Id = 28, ProductId = 24, CategoryId = 4 },
                       new ProductCategory { Id = 29, ProductId = 7, CategoryId = 4 },
                       new ProductCategory { Id = 30, ProductId = 22, CategoryId = 4 },
                       new ProductCategory { Id = 31, ProductId = 13, CategoryId = 4 },
                       new ProductCategory { Id = 32, ProductId = 15, CategoryId = 4 }





              );
        }
    }
}
