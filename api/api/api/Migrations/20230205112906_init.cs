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
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
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
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "IsDeleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "eedb2042-cb09-42f4-829a-3a40dd5f7968", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "1224b026-d3a9-4b7f-81ba-0691f30b5af9", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "89483d11-7e8f-4a0f-8fcd-a6d11c6605d6", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "f056af36-b088-4383-be8b-0ba812f0cb7b", "admin@gmail.com", false, "Admin", false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e906d2a8-b70c-4900-a048-49bcb477373e", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "ac990f26-b322-4520-bea0-852c0d1dda1d", "user@gmail.com", false, "User", false, "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d72a724e-90c4-4093-82ca-46c1b6807b83", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "4a8727a0-0ece-4d74-9f73-7ea1f4195f51", "guest@gmail.com", false, "Guest", false, "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6c70c20e-7024-461f-b178-d9f8cab63b96", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "057c7357-bb76-4391-acf5-a5c53dad78cd", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(9713), false, "Mr. Cierra Lavonne Heathcote Jr.", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(9713) },
                    { "1ae30045-98d5-488f-bc88-e1fd1919fb59", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(8806), false, "Aniya Rosenbaum", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(8806) },
                    { "254bea6c-2bc5-4ec6-9899-4e3b08533a3d", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(5420), false, "Pietro Lowe", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(5421) },
                    { "26a35f16-7798-4cde-8f65-4393dbe4edad", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(6301), false, "Prof. Alyson Kyleigh Von Jr.", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(6301) },
                    { "3c572b81-105d-40ea-9897-b7d03336a674", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(3795), false, "Mafalda Teresa Howell MD", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(3795) },
                    { "8b67e980-44a0-437c-b2c1-43bd87e203bc", new DateTime(2023, 2, 5, 11, 29, 6, 541, DateTimeKind.Utc).AddTicks(9233), false, "Mariane Devin Jakubowski PhD", new DateTime(2023, 2, 5, 11, 29, 6, 541, DateTimeKind.Utc).AddTicks(9236) },
                    { "a9fe18a3-4138-4371-bcf4-f2431e735c9e", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(1042), false, "Prof. Marta Block MD", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(1043) },
                    { "ca93d851-7d02-4de0-bc82-1abbb1b1dc7d", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(7921), false, "Jennie Volkman", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(7921) },
                    { "ce14eda4-cb0c-4379-b13d-114a98317d91", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(2870), false, "Lauriane Durgan", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(2870) },
                    { "e90de408-a3cc-4c48-b753-d9641afea031", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(1977), false, "Jack O'Keefe", new DateTime(2023, 2, 5, 11, 29, 6, 542, DateTimeKind.Utc).AddTicks(1978) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "01c4d110-ec55-442f-87b9-5851138149ee", null, "Vel odio ullam sequi quia qui ut et tempore sed. Itaque consequuntur quisquam alias voluptatem atque sapiente nam. Et laudantium deleniti ipsa vel eos. Est rerum consequatur cumque veniam odit et recusandae recusandae.", new DateTime(2023, 2, 5, 11, 29, 6, 546, DateTimeKind.Utc).AddTicks(3289), "Sint eos quia quis.", false, "Mr. Shany Lynch PhD", 775308L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 546, DateTimeKind.Utc).AddTicks(3293) },
                    { "095be80d-f11c-46aa-a7fc-6bf1ee698fa6", null, "Enim quis expedita voluptas voluptas incidunt. Quia nesciunt ullam aspernatur praesentium aut doloremque est. Vitae aut quis tempore voluptatem et unde quo. Consequatur consequatur quisquam cupiditate accusamus nesciunt.", new DateTime(2023, 2, 5, 11, 29, 6, 544, DateTimeKind.Utc).AddTicks(7276), "Veritatis aliquam facilis molestiae quod quae iure ad magni.", false, "Dr. Scotty Zboncak", 676298L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 544, DateTimeKind.Utc).AddTicks(7279) },
                    { "2d3637cf-f1b3-4643-91a9-4c388a93c7ff", null, "Ut qui alias praesentium veritatis quas odio in. Sequi repellendus optio odit. Deserunt et corporis quae inventore sint nisi. Ut doloribus et et quia. Ad porro ratione laborum dolorem.", new DateTime(2023, 2, 5, 11, 29, 6, 548, DateTimeKind.Utc).AddTicks(1446), "Dolores consequuntur adipisci laudantium et ipsum.", false, "Miss Chelsey Oceane Barton III", 436749L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 548, DateTimeKind.Utc).AddTicks(1449) },
                    { "56bbacbd-2225-4612-9723-bab7fd93f8a2", null, "Et molestias delectus voluptas atque non in porro ullam suscipit. A voluptates ut ullam voluptas in. Porro et quia earum nam consequuntur odit et ut omnis. Aliquid dolores voluptas velit molestiae qui molestiae voluptates sunt.", new DateTime(2023, 2, 5, 11, 29, 6, 547, DateTimeKind.Utc).AddTicks(5488), "Quia magnam facere et sit excepturi omnis ad.", false, "Isom Marquardt", 454650L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 547, DateTimeKind.Utc).AddTicks(5491) },
                    { "5c868d34-37c8-48b7-8d09-54fa86c1a289", null, "Placeat eaque impedit rem sed aut sed ullam. Vitae a facilis eum voluptatem eveniet. Ad est similique quam eum. Facere fugiat et quae et. Inventore quia enim dicta quam et qui.", new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(1347), "Doloribus qui quasi consequatur maxime.", false, "Destiney Grant", 883028L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(1347) },
                    { "870aa1e2-3b2c-4021-b35a-52f49ee14f8a", null, "Minima recusandae at non itaque. Blanditiis amet excepturi autem perferendis aut non error modi. Architecto harum optio repellat. Ipsam modi repellendus et. Officia voluptates sit ut.", new DateTime(2023, 2, 5, 11, 29, 6, 547, DateTimeKind.Utc).AddTicks(605), "Eaque est qui possimus iste.", false, "Miss Devonte Schowalter", 535457L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 547, DateTimeKind.Utc).AddTicks(608) },
                    { "8fcf0c40-9769-47ba-b816-48cdcb2eeaa4", null, "Eligendi non quis a a enim est repellat voluptates maxime. Magni dolorum tempore exercitationem ducimus pariatur fuga explicabo quia esse. Ut sit necessitatibus consequatur. Suscipit voluptatem officiis natus numquam placeat ipsa animi molestias.", new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(4531), "Ab quasi ut ducimus et aperiam dolor quasi quaerat expedita.", false, "Miss Cynthia Monique Adams Sr.", 814871L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(4531) },
                    { "92c37962-ec95-4443-a86d-a0a077b26926", null, "Totam minima quam ipsam iure quam voluptatem ut voluptatem. Et expedita ullam nemo dolorum quia asperiores. Alias nisi ea optio. Doloribus eos et velit modi accusantium reprehenderit corrupti numquam. Quia odio expedita qui maxime. Et et sit animi consequatur eum reiciendis.", new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(9996), "Recusandae iste recusandae placeat aliquid nihil et temporibus.", false, "Geo Chaim Hahn II", 318752L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 543, DateTimeKind.Utc).AddTicks(9998) },
                    { "f1422ece-ad6c-4877-83a6-44e46abe016e", null, "Et error sapiente tempora. Eaque quis dolor sapiente ratione et nulla et. Ut iure adipisci rerum et quidem. Debitis eaque placeat error dicta voluptas.", new DateTime(2023, 2, 5, 11, 29, 6, 545, DateTimeKind.Utc).AddTicks(1401), "Quia non modi nisi aut excepturi odit earum.", false, "Lilla Crooks", 223717L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 545, DateTimeKind.Utc).AddTicks(1404) },
                    { "f56bf040-6fcd-4ad3-b782-f572d09d3b15", null, "Debitis veniam voluptates et similique. Sed ea nobis et sed qui aut sit debitis eaque. Accusamus sunt est modi qui omnis.", new DateTime(2023, 2, 5, 11, 29, 6, 545, DateTimeKind.Utc).AddTicks(8395), "Temporibus pariatur a et rerum iste vero et modi.", false, "Reginald Gerlach", 983616L, 1, 0L, new DateTime(2023, 2, 5, 11, 29, 6, 545, DateTimeKind.Utc).AddTicks(8398) }
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
