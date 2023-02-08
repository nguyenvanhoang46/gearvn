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
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "6770b137-fe39-457c-9b1c-fd00e9025855", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "7656d1f5-af1f-4289-84a2-77cf1d34f550", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "3d306e59-8786-45f5-bea2-b0cb01a7dda4", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "f9b3a70d-d34f-40c2-be3b-c8829ef55f20", "admin@gmail.com", false, "Admin", false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38f118fd-b7eb-43d5-93a7-e8f5aac33eef", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "d119fc3c-0531-41fd-ba42-5ffff8139d88", "user@gmail.com", false, "User", false, "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aeceed83-b500-4312-80f7-9809dbcc93a4", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "13e56d87-df9e-46e2-956b-0f5028d059b8", "guest@gmail.com", false, "Guest", false, "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8882bed-4dcc-438c-9eb6-53674068464a", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "107a3a95-7de9-43a6-84d3-6492e2dde0a0", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(7797), false, "Marques Jones", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(7797) },
                    { "2a3304f0-3e41-4af3-b41c-780339ac8be7", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(8325), false, "Milford Armstrong", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(8325) },
                    { "51739595-9189-47a8-9179-c4d79e625944", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(9913), false, "Miller O'Hara I", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(9914) },
                    { "55a4e8e3-bc3f-4d5f-be8d-e4ed25528162", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(2654), false, "Mrs. Meagan Trevion Buckridge III", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(2654) },
                    { "6a86801b-dd82-4780-9416-278678682c44", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(5228), false, "Dr. Hazel Leo Mayer", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(5228) },
                    { "940648ee-1e5e-4237-8509-eff2aa28dbf4", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(1791), false, "Mario Borer", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(1792) },
                    { "a0d701b6-ce97-4fb5-bb7b-627546e72ce6", new DateTime(2023, 2, 8, 15, 51, 16, 839, DateTimeKind.Utc).AddTicks(7371), false, "Roy Lang", new DateTime(2023, 2, 8, 15, 51, 16, 839, DateTimeKind.Utc).AddTicks(7374) },
                    { "d1b62435-a345-4b4d-9f90-3b885dc72053", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(4322), false, "Mr. Dominic Murphy II", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(4323) },
                    { "ee3ba930-9ecc-4d88-ac06-d982a8edb2bb", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(878), false, "Mrs. Brannon Fritsch", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(879) },
                    { "fa8376b5-c742-44a2-a528-6ddf834f7ccb", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(5941), false, "Orie Fay III", new DateTime(2023, 2, 8, 15, 51, 16, 840, DateTimeKind.Utc).AddTicks(5943) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "0ef87065-5abb-4fd2-8a11-7f3463566fab", null, "Dolore repellat itaque sit et explicabo numquam quidem vel. Molestiae amet sunt optio aut sed molestias quis nam. Consequuntur cumque ducimus quos provident saepe nostrum est deserunt.", new DateTime(2023, 2, 8, 15, 51, 16, 844, DateTimeKind.Utc).AddTicks(1932), "Unde laudantium doloribus maiores quo temporibus omnis minus.", false, "Jerad Senger", 908348L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 844, DateTimeKind.Utc).AddTicks(1932) },
                    { "0fc51aff-8135-412b-9e69-11354cdb7566", null, "Est eos id minus cum est iure et iusto. Et deleniti est ipsum quos nihil sunt consequatur tempore. Omnis sequi rerum porro ab.", new DateTime(2023, 2, 8, 15, 51, 16, 843, DateTimeKind.Utc).AddTicks(7933), "Ut alias et est omnis deserunt eveniet quae quis accusantium.", false, "Bernard Ryan", 570847L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 843, DateTimeKind.Utc).AddTicks(7933) },
                    { "1d30dfd8-c425-4eb2-b376-8a1d1807720e", null, "Totam amet pariatur accusamus sunt dolores quia harum. Occaecati officiis dolores sint eligendi eos et officiis expedita. Quo laudantium iure quo nemo voluptatum nobis adipisci earum. Hic numquam quasi cum.", new DateTime(2023, 2, 8, 15, 51, 16, 842, DateTimeKind.Utc).AddTicks(3654), "Blanditiis exercitationem quidem tenetur quia dolores iusto.", false, "Miss Marianna Beer", 727160L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 842, DateTimeKind.Utc).AddTicks(3655) },
                    { "7a70a52d-cd8e-44c6-b245-13be0ecb3fe8", null, "Repellat non eos beatae repellendus. Repellendus nihil ab et aliquam natus repellat quia. At pariatur excepturi nemo et. Illo repellendus dignissimos omnis. Commodi eum enim quam.", new DateTime(2023, 2, 8, 15, 51, 16, 845, DateTimeKind.Utc).AddTicks(1638), "Non et et vero tenetur voluptate odio.", false, "Allene Thompson", 220788L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 845, DateTimeKind.Utc).AddTicks(1639) },
                    { "7c2c0627-944d-415b-b2bd-3519f369643d", null, "Saepe iure cupiditate et consectetur facere consequatur est est. Distinctio qui totam unde qui. Sunt earum maiores qui architecto minus.", new DateTime(2023, 2, 8, 15, 51, 16, 842, DateTimeKind.Utc).AddTicks(9001), "Magnam ut eius ipsum ducimus eum rem et reiciendis.", false, "Ms. Wava Catherine Gutmann Sr.", 565231L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 842, DateTimeKind.Utc).AddTicks(9001) },
                    { "880e3ad1-0bd7-4ff3-b850-ecc2d0102529", null, "Quam fuga beatae architecto quasi asperiores iste eveniet aut est. Quisquam quia ea dolores aut facere ab. Nulla et molestiae repellendus et. Fugit nobis voluptate magni omnis non vel magnam perferendis. Nostrum accusamus quae delectus omnis maiores.", new DateTime(2023, 2, 8, 15, 51, 16, 843, DateTimeKind.Utc).AddTicks(4284), "Soluta et fugit aut dolores ut corrupti consectetur ex deserunt.", false, "Humberto Dibbert", 214942L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 843, DateTimeKind.Utc).AddTicks(4284) },
                    { "88a60a5e-44b1-419c-aa34-25296f36dd03", null, "Et sit est dolores optio. Ut cum corporis et rem deserunt deleniti illum voluptate laudantium. Recusandae deserunt ullam praesentium distinctio reprehenderit quis accusantium. Molestiae eius voluptas sit occaecati et in tenetur doloribus. Voluptas id quos sit omnis delectus.", new DateTime(2023, 2, 8, 15, 51, 16, 844, DateTimeKind.Utc).AddTicks(5511), "Ut omnis animi et.", false, "Jody Lysanne Corkery PhD", 428848L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 844, DateTimeKind.Utc).AddTicks(5511) },
                    { "b914f56b-394a-44c1-b1fc-bf47026ff2c0", null, "Pariatur illo magni molestiae sapiente cum aut. A expedita odit velit occaecati consectetur alias nulla alias. Quam est porro explicabo esse at voluptatem aut earum. Earum sint quibusdam quisquam qui illo maxime qui excepturi. Soluta voluptas voluptas aut itaque fugit magnam.", new DateTime(2023, 2, 8, 15, 51, 16, 845, DateTimeKind.Utc).AddTicks(5917), "Quia maxime vero ut aut modi.", false, "Adolphus Huel", 291365L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 845, DateTimeKind.Utc).AddTicks(5918) },
                    { "d31bc077-d7de-4b78-ae67-76ad231b17c7", null, "Quis eius ut modi quod deserunt fugit corporis porro. Quasi facere iure veritatis eius consectetur necessitatibus. Non quia et pariatur odit non necessitatibus. Occaecati vel voluptas magnam consequuntur.", new DateTime(2023, 2, 8, 15, 51, 16, 846, DateTimeKind.Utc).AddTicks(1080), "Cupiditate quam et quae qui est libero dignissimos.", false, "Walker Kathlyn Nitzsche I", 916380L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 846, DateTimeKind.Utc).AddTicks(1081) },
                    { "d4d70b70-42a8-4746-86ce-15ab45c21c69", null, "Qui eligendi accusamus molestias reiciendis qui. Unde eius dignissimos saepe ut distinctio. Sint occaecati qui tenetur.", new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(8701), "Est et numquam commodi quo illo.", false, "Mrs. Genesis Reichel", 616921L, 1, 0L, new DateTime(2023, 2, 8, 15, 51, 16, 841, DateTimeKind.Utc).AddTicks(8701) }
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
