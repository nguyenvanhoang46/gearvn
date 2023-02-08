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
                    City = table.Column<string>(type: "longtext", nullable: false)
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
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "0f48b9a0-6c21-4d7c-9313-5aa0377f59ab", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "c2905d59-94d4-4d1c-a165-eeaad38a2f4e", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "965a7bcf-8ed1-41cb-b420-9795074b6055", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "a3444d9e-0296-4bba-ba58-ab97862e60dc", "admin@gmail.com", false, "Admin", false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a5a7225-4270-419f-aee6-20edf10af073", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "8f8c13a0-a58e-47c5-bcb4-292d08eaaf0e", "user@gmail.com", false, "User", false, "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3de19989-8d93-40b8-b453-6a5733f87559", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "ce803c06-3765-4eb4-b86d-099558927c78", "guest@gmail.com", false, "Guest", false, "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "80c418bd-56fd-4b85-88d0-00af1d3e0b7e", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "066c1dff-f6cb-49b6-8d83-1a222dea650f", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(6282), false, "Leonor Toy", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(6283) },
                    { "1030b813-4d10-4539-96ea-8544907b7b29", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(4902), false, "Turner Emmerich", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(4902) },
                    { "13cdbb17-7050-4aba-89f1-38d4a5af8819", new DateTime(2023, 2, 8, 8, 6, 34, 690, DateTimeKind.Utc).AddTicks(5649), false, "Jena West", new DateTime(2023, 2, 8, 8, 6, 34, 690, DateTimeKind.Utc).AddTicks(5653) },
                    { "3aed4bce-ec44-4a30-94ff-11f48740ac14", new DateTime(2023, 2, 8, 8, 6, 34, 690, DateTimeKind.Utc).AddTicks(7197), false, "Giovanni Tracy Kirlin II", new DateTime(2023, 2, 8, 8, 6, 34, 690, DateTimeKind.Utc).AddTicks(7198) },
                    { "4150c5ba-10c3-40ec-bcb6-df540b968c51", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(7805), false, "Ms. Kenyatta Gislason", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(7806) },
                    { "5be87de1-b3bf-4bac-9144-73bd36edf921", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(849), false, "Justus Kraig Osinski I", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(849) },
                    { "947f1398-d52e-4f1a-8e31-6d2fbf27a41c", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(1417), false, "Arden Friesen Jr.", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(1418) },
                    { "c5e15828-b79d-4dc9-ae8d-26f41d8c68f5", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(3359), false, "Erin Schneider", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(3359) },
                    { "c699a308-a4a5-4fd4-89ce-be3a757bfcf7", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(9072), false, "Miss Alexys Alex Parisian", new DateTime(2023, 2, 8, 8, 6, 34, 691, DateTimeKind.Utc).AddTicks(9072) },
                    { "f4e3da1d-44d4-421e-a449-baa6d56ee73e", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(2714), false, "Lue Glover", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(2714) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "0e8e15d2-3f49-402e-9516-bffdae3b649e", null, "Eos enim consequuntur corporis ipsam omnis expedita nisi delectus sed. Aperiam necessitatibus vero omnis dolore id accusamus asperiores. Incidunt iste et ut autem et. Est natus saepe sapiente ullam ut dolores ratione dolorum ad. Ullam nobis necessitatibus quis laboriosam fugiat qui inventore.", new DateTime(2023, 2, 8, 8, 6, 34, 695, DateTimeKind.Utc).AddTicks(6759), "Amet fugit alias beatae culpa non quo.", false, "Joey Stokes", 615925L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 695, DateTimeKind.Utc).AddTicks(6760) },
                    { "3120c60c-aa52-40ab-8a54-f4fd93a81de8", null, "Veniam magni vitae repudiandae ea non laboriosam consequatur inventore nobis. Nemo hic dignissimos pariatur. Fugit est odit at. Id quia qui officiis ut.", new DateTime(2023, 2, 8, 8, 6, 34, 696, DateTimeKind.Utc).AddTicks(7547), "Neque dolorem praesentium repellendus.", false, "Mr. Britney Little", 103031L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 696, DateTimeKind.Utc).AddTicks(7548) },
                    { "4180835a-4151-4b9e-82d8-87c688310f59", null, "Quo nam quo et incidunt qui hic. Fuga voluptates corporis dolor dolorem debitis. Similique assumenda quis placeat voluptatem ullam eveniet reprehenderit iure. Sed mollitia atque cumque qui ut ut. Aperiam odit est sit.", new DateTime(2023, 2, 8, 8, 6, 34, 694, DateTimeKind.Utc).AddTicks(711), "Et modi provident vel repellendus incidunt necessitatibus.", false, "Dr. Eliezer Torp Jr.", 427588L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 694, DateTimeKind.Utc).AddTicks(711) },
                    { "6d4ff129-5d22-4251-aac9-28cefc75dbfa", null, "Consequatur aperiam atque magni magnam fugit. Repellendus quas et veritatis cupiditate velit sit non. Velit velit qui id earum. Possimus natus vel deleniti. Molestias nihil nostrum fugit sint. Sunt temporibus asperiores saepe dicta.", new DateTime(2023, 2, 8, 8, 6, 34, 697, DateTimeKind.Utc).AddTicks(1054), "Vitae est illo non a nam et.", false, "Fausto Hauck", 417888L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 697, DateTimeKind.Utc).AddTicks(1055) },
                    { "964a8a81-20f9-46fc-8107-d8f40e845b90", null, "Eum perspiciatis modi error possimus officia consequatur. Vel magni reiciendis libero et ullam nisi. Numquam laboriosam beatae doloribus. Qui eum dolorem eveniet quod saepe.", new DateTime(2023, 2, 8, 8, 6, 34, 695, DateTimeKind.Utc).AddTicks(1955), "Est est provident excepturi quia hic dolores earum.", false, "Dave Zboncak", 992146L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 695, DateTimeKind.Utc).AddTicks(1959) },
                    { "afe8e109-1eca-4d1d-9d9c-c57350339b92", null, "Et eveniet optio corrupti libero asperiores voluptatum voluptatem ea. Sed rerum aliquam debitis ea hic possimus. Magnam unde voluptas vel tempora voluptas voluptates quam tempore.", new DateTime(2023, 2, 8, 8, 6, 34, 694, DateTimeKind.Utc).AddTicks(7068), "Non perspiciatis inventore qui enim et quibusdam.", false, "Prof. Maurice Runolfsdottir", 751097L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 694, DateTimeKind.Utc).AddTicks(7069) },
                    { "c34b76af-ed66-4cf4-9c4b-a4870759449d", null, "Perferendis beatae nam cumque aut porro. Repellendus rerum sint exercitationem commodi qui suscipit non doloribus. Aut aut nihil velit non sit a. Quisquam harum praesentium provident sunt eos. Modi nesciunt tempore iste esse facere quas molestiae.", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(3978), "Nostrum et voluptatibus iste rem.", false, "Emerald Brakus II", 860971L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(3979) },
                    { "ce7f19d7-23a2-4a9f-850a-3e615437777b", null, "In optio sint dolorum omnis adipisci eos numquam nobis. Quia quisquam corporis minima rerum ipsa impedit explicabo aut amet. Nemo dolorem ratione et autem nihil. Fugit deserunt perspiciatis unde facilis.", new DateTime(2023, 2, 8, 8, 6, 34, 696, DateTimeKind.Utc).AddTicks(2012), "Mollitia repudiandae ut quo aut.", false, "Prof. Kianna Fern Boyle", 695212L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 696, DateTimeKind.Utc).AddTicks(2013) },
                    { "e05702e1-86ba-4df6-9c37-225b82a5e868", null, "Ut soluta harum id id fuga qui ea aliquid voluptatem. Maxime facere perspiciatis deleniti enim. Nihil voluptates ex vel sint. Id hic nisi quia ut sunt. Minus voluptatem consequatur magnam quos blanditiis quae. Hic quia quia laborum ex ab cumque non voluptatem.", new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(9025), "Ratione consequatur ipsum et aperiam.", false, "Miss Roberto Schmidt", 939093L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 692, DateTimeKind.Utc).AddTicks(9025) },
                    { "fffa018f-e5b2-46ad-bec1-d06f0e9e0f37", null, "Rerum harum sit molestiae non omnis debitis omnis eaque iste. Tempora aut provident inventore ut ut. Et quibusdam et exercitationem ut velit. Eum a iusto et vel possimus quia reprehenderit. Aliquid dignissimos nobis voluptas.", new DateTime(2023, 2, 8, 8, 6, 34, 693, DateTimeKind.Utc).AddTicks(4978), "Fugiat ut id eum omnis consequuntur ut.", false, "Oswald Fabian Stracke I", 114070L, 1, 0L, new DateTime(2023, 2, 8, 8, 6, 34, 693, DateTimeKind.Utc).AddTicks(4979) }
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
