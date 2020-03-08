﻿// <auto-generated />
using System;
using FreakyFashion2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreakyFashion2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200205125022_change-sale-products")]
    partial class changesaleproducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreakyFashion2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trouthers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shirts"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dresses"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sale"
                        });
                });

            modelBuilder.Entity("FreakyFashion2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Material: 98% bomull, 2% elastan",
                            ImageUrl = "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=1800",
                            Name = "Chinos",
                            Price = 300f,
                            ProductNumber = "02343211234"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Material: Material: 100% polyester",
                            ImageUrl = "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762",
                            Name = "TRAIN LOGO PANT",
                            Price = 400f,
                            ProductNumber = "02343211234"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Material: Best Byxor",
                            ImageUrl = "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762",
                            Name = "HYBRID PANT",
                            Price = 400f,
                            ProductNumber = "01231234"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Material: 90% polyester, 10% elastan",
                            ImageUrl = "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg",
                            Name = "FLEX WOVEN",
                            Price = 200f,
                            ProductNumber = "032213"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Material: 79% bomull, 21% polyester",
                            ImageUrl = "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg",
                            Name = "TAPE PANTS",
                            Price = 700f,
                            ProductNumber = "032213"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg",
                            Name = "Tygbyxor",
                            Price = 400f,
                            ProductNumber = "0231241"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Material: 84% polyester, 15% viskos, 1% elastan",
                            ImageUrl = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg",
                            Name = "Tygbyxor-b",
                            Price = 200f,
                            ProductNumber = "023990"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Material: 97% bomull, 3% elastanr",
                            ImageUrl = "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$",
                            Name = "Tygbyxor",
                            Price = 200f,
                            ProductNumber = "02329980"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg",
                            Name = "Piké",
                            Price = 700f,
                            ProductNumber = "10098"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2",
                            Name = "FLORAL PANEL - Piké",
                            Price = 100f,
                            ProductNumber = "10987712"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg",
                            Name = "CHECK - Piké",
                            Price = 190f,
                            ProductNumber = "10976152"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Material: 60% bomull, 40% polyester",
                            ImageUrl = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg",
                            Name = "Sweatshirt",
                            Price = 200f,
                            ProductNumber = "1231320091"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium",
                            Name = "Piké",
                            Price = 400f,
                            ProductNumber = "12313212131"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png",
                            Name = "BASIC 2 PACK - Piké",
                            Price = 700f,
                            ProductNumber = "189912002"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg",
                            Name = "GEO ALL - Piké",
                            Price = 200f,
                            ProductNumber = "12313299901"
                        },
                        new
                        {
                            Id = 16,
                            Description = "MATERIAL & SKÖTSEL",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN",
                            Name = "CAMBRIDGE - Piké",
                            Price = 300f,
                            ProductNumber = "112312"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475",
                            Name = "TAMAYO DRESS",
                            Price = 900f,
                            ProductNumber = "2221312131321"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://photo.venus.com/im/18062700.jpg?preset=product",
                            Name = "MNIA DRESS",
                            Price = 200f,
                            ProductNumber = "2231321"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg",
                            Name = "GILLEA - Skjortklänning",
                            Price = 1200f,
                            ProductNumber = "223000989"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                            Name = "VALENTINA DRESS - Skjortklänning",
                            Price = 400f,
                            ProductNumber = "2231099212"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                            Name = "AMARIS LONG KIMONO",
                            Price = 2000f,
                            ProductNumber = "22099812"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                            Name = "CETO DRAWSTRING",
                            Price = 300f,
                            ProductNumber = "209990"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                            Name = "NINGBOX - Skjortklänning",
                            Price = 400f,
                            ProductNumber = "29761125"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-",
                            Name = "PCNICOLETTA DRESS - Skjortklänning",
                            Price = 1500f,
                            ProductNumber = "200918"
                        });
                });

            modelBuilder.Entity("FreakyFashion2.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            ProductId = 10
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            ProductId = 11
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            ProductId = 12
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            ProductId = 13
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            ProductId = 14
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            ProductId = 15
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            ProductId = 16
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            ProductId = 17
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            ProductId = 18
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            ProductId = 19
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            ProductId = 20
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            ProductId = 21
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            ProductId = 22
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            ProductId = 23
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            ProductId = 24
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            ProductId = 12
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            ProductId = 15
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            ProductId = 24
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            ProductId = 22
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 4,
                            ProductId = 13
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 4,
                            ProductId = 15
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FreakyFashion2.Models.ProductCategory", b =>
                {
                    b.HasOne("FreakyFashion2.Models.Category", "Category")
                        .WithMany("ProductCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreakyFashion2.Models.Product", "Product")
                        .WithMany("ProductCategory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
