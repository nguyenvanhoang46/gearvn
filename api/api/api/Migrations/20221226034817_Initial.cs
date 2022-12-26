using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Initial : Migration
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
                    OrderType = table.Column<int>(type: "int", nullable: false),
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
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "48231ff4-2bb9-4ce3-ad5e-0808cb3d3a42", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "1d37f90a-fcbf-4e1f-b13a-216e962e17c3", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "efe42aad-1448-4740-bae2-146dbd3c4e1a", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "9b3dc9c7-9274-4bd3-9fd2-fb587cde0435", "admin@gmail.com", false, "Admin", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f9b8c16-0019-42d2-942f-94460e0b151b", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "aa9eb516-cf2b-4ee0-a353-fb20272973f3", "user@gmail.com", false, "User", "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "141ae25e-f808-47c0-839c-d1ec2f8a18af", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "9ecfb82d-6ec1-45dd-953a-ef4b93046d15", "guest@gmail.com", false, "Guest", "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9833f343-a286-49d8-afc4-15c956e75133", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "046249b3-7e4d-4a05-ad3a-efe1fa54f3b6", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(7136), false, "Faustino Goldner III", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(7136) },
                    { "1f7f2d3e-dfbc-4669-8d0f-0f9f6a8c6919", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(96), false, "Octavia McClure", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(96) },
                    { "250d1a43-afb4-4b09-94fa-776e1bb531eb", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(2877), false, "Ida Wuckert", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(2877) },
                    { "2bc7858f-d35a-4da7-be79-0e77912f7194", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1013), false, "Zena Hoppe", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1013) },
                    { "2be6f46b-2f6c-494e-9734-1f1f0e49ee34", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(9173), false, "Chelsie King", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(9173) },
                    { "353a134a-076b-4df8-8ab5-93ec30cf6608", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(3743), false, "Reyes Hickle", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(3743) },
                    { "37b579a6-fbdf-4f85-85a1-85a90fa7f020", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(4813), false, "Deanna Bartoletti", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(4814) },
                    { "386d32ae-3c53-4db1-9452-a95e4e1e4bc6", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1958), false, "Marcelo Labadie", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1958) },
                    { "7ac24e7e-703e-4616-9a7b-a071d03a15bd", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(8161), false, "Julio Donnelly", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(8161) },
                    { "c6e33434-cdc4-4031-98ad-473ce68b0b79", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(5909), false, "Buford Rippin", new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(5912) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "0250efd3-de7f-4253-99aa-240ffd8bb4ae", null, "Accusamus omnis dolore et. Ipsum quia aspernatur cum numquam voluptas porro. Aspernatur non repudiandae et et fugiat. Voluptatem quos labore vel ea aliquid deserunt accusantium. Eveniet aperiam nihil provident earum alias et molestiae. Quos et voluptatem natus in est quod.", new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(3236), "Aspernatur enim vel minima dolorem ex deleniti iure modi.", false, "Prof. Ernestina Muller PhD", 430783L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(3237) },
                    { "0aff9e69-fd7c-4f65-9fb5-cf02e0ace38a", null, "Id iste praesentium nesciunt sunt voluptatem. Et explicabo cum doloribus aut consequatur vitae voluptatem corporis. Omnis est eos corrupti porro veritatis. Est et officiis rerum. Id non qui enim dolorum qui porro et. Alias est molestias facilis voluptatibus alias nemo qui illo tempora.", new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(5886), "Rem reiciendis quo ex adipisci itaque.", false, "Mrs. Gene Magdalen Witting", 110137L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(5886) },
                    { "0c5ecfc9-2e67-4709-9858-572b4007d07e", null, "Quidem suscipit totam dicta modi neque nobis laudantium voluptatum harum. Repellendus inventore ut quidem veritatis sed dolorem placeat vitae. Voluptas consequuntur et dolores. Non sit eos numquam tempore reiciendis ut rerum molestias voluptatem. Ut laudantium quibusdam ipsam. Quia soluta autem perspiciatis eius assumenda illo consectetur provident recusandae.", new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(6231), "Ea omnis libero laboriosam quae itaque repellendus explicabo.", false, "Ivy Graham DDS", 174264L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(6232) },
                    { "40a1bd7d-f011-455c-b8d4-2b5a3c7169d9", null, "Aut quia voluptatem sunt rerum provident eum est ullam quod. Nihil aut doloribus sit aut quo nisi eligendi ducimus. Voluptatem quod qui nostrum et id non sunt. Sint non quam dolorem laborum libero.", new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(7081), "Accusamus vitae sed et quo libero.", false, "Bryce Bins", 523218L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(7084) },
                    { "56639b8a-46f6-45f9-8e50-3fb2ae3f7290", null, "Assumenda in neque nostrum. Sunt modi dolorem aut et. Omnis vel veritatis reiciendis consequatur qui. Ipsa veniam in aut. Non omnis cumque quaerat dolores aut quos aut autem quidem. Totam repudiandae quidem ut et et excepturi vero ducimus.", new DateTime(2022, 12, 26, 3, 48, 17, 34, DateTimeKind.Utc).AddTicks(251), "Ut dolore aliquam velit rem est ea.", false, "Jerald Ritchie", 776616L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 34, DateTimeKind.Utc).AddTicks(252) },
                    { "8922a27b-5d4c-41b6-a9f3-92307b4e5956", null, "Eum ratione dolores vero officia dolorem iure. Et ea facilis et eligendi magni non non aut et. Qui quo ipsum fugiat illum beatae quaerat rerum vero quis. Reprehenderit consequuntur sed vel sunt voluptatibus quisquam. Delectus rem numquam corporis laudantium voluptatem velit delectus omnis. Veniam ut sint esse mollitia et aliquam quia.", new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(3350), "Eum porro voluptatem facere fugiat ut nemo maiores.", false, "Miss Katlyn Tyrell Renner", 538866L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(3351) },
                    { "9c1043b8-9702-40e9-a813-c7730d4dd042", null, "Vel itaque quia velit minima. Eaque sunt ducimus rerum. Quas eveniet sit at ipsum reprehenderit corporis expedita et veniam.", new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(3488), "Nisi quia dignissimos vel ut est consectetur quia omnis et.", false, "Elfrieda Schulist", 761109L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(3490) },
                    { "c0040539-3dcc-49ed-86c5-e0006f043b1c", null, "Fuga nostrum alias rerum iste nemo consequatur. Eum reprehenderit aut reprehenderit et quam aliquam soluta. Quod velit officiis deserunt saepe molestias optio. Vero tempore nihil quo nostrum aut.", new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(390), "Nisi in necessitatibus labore.", false, "Benny Wuckert", 298439L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(391) },
                    { "c5f02cba-30be-4bc9-af41-e610e47d22f5", null, "Veniam et autem qui corrupti sed. Ullam est esse sunt nam. Tenetur qui magni soluta beatae perferendis libero quia ad. Exercitationem rerum quae quibusdam architecto id eos dicta et. Necessitatibus minima ea iste rerum eum omnis vitae quae ut. Et mollitia quas earum non molestias non non minima.", new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(8570), "Dolores reprehenderit saepe in quia ipsum voluptas eum doloribus.", false, "Miss Frank Douglas", 142752L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(8571) },
                    { "e70805b1-1a8d-42cd-ada2-706fdcea6fc1", null, "Est ut consequuntur temporibus vero asperiores perferendis harum. Non reiciendis atque quo expedita ipsa. Sed maiores aut est sint est nihil veritatis nesciunt.", new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(622), "Ipsa vel cumque alias est exercitationem.", false, "Juliana Anderson", 516561L, 1, 0L, new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(623) }
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
