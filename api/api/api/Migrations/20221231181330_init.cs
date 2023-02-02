using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshToken = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    OrderCompletionType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alt = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MimeType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "b857d74d-b9a3-43a7-a80b-492e6d203d6c", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "421a1269-d467-4a7a-8b5d-e05c578c46d5", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "e71f235d-9ebf-49e9-aa40-cdf596516c3a", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "a08e5ad9-28e0-4f60-bb8c-c8002b0183db", "admin@gmail.com", false, "Admin", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "156d842f-00d0-40ed-a19c-ae460d0559b5", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "dd963ab8-f3fe-46eb-8a91-be552afde1cb", "user@gmail.com", false, "User", "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f7844d72-cd13-4beb-bc57-9920c67b8333", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "0d5437d1-c063-4339-b0ab-e23078333747", "guest@gmail.com", false, "Guest", "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "848077e4-b9d3-4440-b976-6f4e904bc6b6", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "25a77564-0c0e-46c3-9b17-ec4c295e0911", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(9527), false, "Paxton Cartwright", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(9527) },
                    { "2c3bb582-a3eb-4d8d-ab97-f1be68b20785", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(3037), false, "Danial Marquardt", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(3037) },
                    { "4c9d3b90-dfcd-4f53-9f7a-41d8e970ca88", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(432), false, "Jammie Rodolfo Boyle V", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(433) },
                    { "927a829d-a855-45cc-b5ef-020524bfbe98", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(452), false, "Mr. Julio Pacocha", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(452) },
                    { "ae54eea6-1e52-487b-a3c7-203f7cf46dd4", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(2064), false, "Gage Leuschke", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(2065) },
                    { "ca722bb2-4ae8-45ea-b411-b5b51ab97cd5", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(8476), false, "Andreane Hodkiewicz", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(8477) },
                    { "e0594e9f-f51f-4213-af36-b6cf5a3334e0", new DateTime(2022, 12, 31, 18, 13, 29, 828, DateTimeKind.Utc).AddTicks(9388), false, "Felipe Willms", new DateTime(2022, 12, 31, 18, 13, 29, 828, DateTimeKind.Utc).AddTicks(9390) },
                    { "e904c016-2a4c-46d6-a2ea-69b345f1fd00", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(7118), false, "Rudy Hyatt", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(7119) },
                    { "f19fb9ed-6ad6-42ba-a5b5-07884422223d", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(3141), false, "Miss Uriel Wendy Cassin", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(3142) },
                    { "fc426f7c-5f16-4c9a-b96c-0d4c9006fd8d", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(5694), false, "Nicolette Bogisich", new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(5695) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "04e07f8a-c08b-4087-b886-d84f47d1bb59", null, "Amet numquam et quos maiores suscipit neque quae consequuntur eligendi. Dolorem unde non in assumenda corrupti ut doloribus qui ex. Placeat et veritatis facilis tempora aut. Doloremque est hic dolor qui vel nesciunt a quod. Voluptas eligendi hic quia reiciendis et rem eveniet molestiae odio.", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(8427), "Suscipit hic doloremque repudiandae itaque voluptatem.", false, "Brain King", 376882L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(8429) },
                    { "4010a15c-4e8d-4712-9c52-b40abb6f2b50", null, "Doloremque et doloremque labore est repellendus veniam ipsam. Fugit quam deleniti delectus odio eos. Vel sed quam labore consequatur deleniti voluptatem. Dolorem dolores itaque qui nam. Sit maxime ut reiciendis aliquid.", new DateTime(2022, 12, 31, 18, 13, 29, 833, DateTimeKind.Utc).AddTicks(4930), "Repudiandae aliquam sit repellat.", false, "Prof. Kobe Kaitlyn Padberg", 936967L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 833, DateTimeKind.Utc).AddTicks(4931) },
                    { "432de664-819d-4272-b129-9cfdc98cd816", null, "Voluptatum distinctio doloribus consequatur ea esse. Necessitatibus sed at voluptates id. Fugiat veniam et voluptates fugit perspiciatis omnis deleniti. Sed dolore odio eveniet.", new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(156), "Occaecati magni et reiciendis aut et quis esse et nisi.", false, "Prof. Izabella Jeanie Terry", 206418L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(157) },
                    { "68e72d95-e3d7-4ca4-9f83-428d24d951d5", null, "Alias quae voluptatem sit iusto ut. Laborum temporibus amet aut error saepe sed veniam et accusantium. Dolore consequatur asperiores expedita suscipit natus consequatur error et. Itaque odit nihil saepe voluptatem in. Dicta unde velit beatae ut ducimus porro necessitatibus maiores. Vel sunt quidem est et odio sed.", new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(4450), "Dolores eum quam et velit inventore facilis.", false, "Dr. Beryl Sam D'Amore", 854246L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(4451) },
                    { "6cc1f7ac-99f6-4afd-9bb5-85fcdec9e930", null, "Explicabo reprehenderit vel non quibusdam explicabo. Sed voluptates est nisi aut et fugit hic. At modi esse et consequuntur asperiores libero.", new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(1197), "Odio repellendus recusandae rerum est.", false, "Prof. Rubye Johan Orn DVM", 335915L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(1197) },
                    { "9f44c4db-7349-4c1e-90a7-6a521c5e3420", null, "Itaque laudantium et assumenda repudiandae. Qui exercitationem magni quis. At dolores est sit omnis vero autem occaecati vero.", new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(4407), "Ratione vel iusto qui minus eveniet.", false, "Nella Murphy", 638306L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(4408) },
                    { "adb930f1-e844-4303-932c-c5c2b9b38ac4", null, "Sequi enim nihil maxime autem velit. Mollitia molestias qui quod quia reiciendis consequatur. Veniam voluptate nam reiciendis soluta enim quia natus dolorum.", new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(3854), "Eum et quas non aliquam.", false, "Lucio Jacobs", 111210L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(3855) },
                    { "cf60152a-aac5-4632-b964-029d87bd929a", null, "Aspernatur vero repellat quis reprehenderit sed id officia quod. Molestiae temporibus ex non culpa id. Tempore corrupti enim eos atque velit aliquam dolorum.", new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(4389), "Occaecati vitae nesciunt enim voluptatum.", false, "Herbert Ritchie", 708097L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(4390) },
                    { "e8a28e99-ad41-4aa3-a154-e5e72b174a54", null, "Omnis animi eaque illum libero debitis natus. Impedit voluptas necessitatibus quidem assumenda. Dolorum nobis fuga rerum nulla. Nulla et nihil cumque doloribus eaque. Aperiam et est aut ut.", new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(6411), "Perferendis eligendi asperiores autem non reiciendis aperiam.", false, "Dorian Zieme", 836000L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(6411) },
                    { "f4947ecc-c6b9-44b2-bd4f-39f341f3a196", null, "Earum repellat voluptatem quia inventore. Doloremque incidunt hic suscipit est quo iure. Praesentium quisquam sed ut. Omnis sed distinctio voluptatem vel vel in sed eius. In dolor vero et quisquam est delectus laboriosam libero aut. Impedit veniam excepturi sit excepturi voluptas et qui tenetur pariatur.", new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(8424), "Dolorem eveniet accusantium soluta enim dolor voluptatem excepturi.", false, "Gonzalo Borer", 628161L, 1, 0L, new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(8425) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "2dfb43f4-24d5-44a7-af3c-78196e881f23" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "75fa9827-0f5f-41db-a825-64d68d242d7e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b600478d-f98b-4a27-aa95-14563920d28f", "df31566d-5ccb-45dc-b1be-864d72133ca4" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
