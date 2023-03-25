using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class init1 : Migration
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
                    { "b600478d-f98b-4a27-aa95-14563920d28f", "5206410b-a4e1-4d89-a4e0-5efce5888d71", "Role", false, "Guest", "GUEST" },
                    { "cc3b4c20-7ab3-4daa-b777-0018ee8c615c", "a8179dc6-5f5a-4e36-9e08-429e80a0cf61", "Role", false, "Admin", "ADMIN" },
                    { "dddd1a59-3b57-45f6-96b5-91b3e269e87c", "ee8ccc89-371c-487d-9600-d36ee576efe6", "Role", false, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dfb43f4-24d5-44a7-af3c-78196e881f23", 0, "4ed75fd8-b93c-44e2-9073-0cae01936c73", "admin@gmail.com", false, "Admin", false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "186423ff-5998-4d13-a442-f386fca41ba6", false, "Admin" },
                    { "75fa9827-0f5f-41db-a825-64d68d242d7e", 0, "b76fdbcc-d2cd-4bb8-b346-eb2e5202c22d", "user@gmail.com", false, "User", false, "User", false, null, "USER@GMAIL.COM", "USER", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8d5a991c-556c-4839-8650-4ed28075ca6a", false, "User" },
                    { "df31566d-5ccb-45dc-b1be-864d72133ca4", 0, "a3461dfa-4d12-40a2-a84d-889f8b0e816d", "guest@gmail.com", false, "Guest", false, "Guest", false, null, "GUEST@GMAIL.COM", "GUEST", "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a50da4a-24a9-4410-b7be-c73e0842adee", false, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "021f916b-ea77-4231-af55-7c06c03216cf", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(4158), false, "Miss Donnie Collier", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(4158) },
                    { "022f9f9b-6bb0-4831-a8c9-af4bded1052d", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(2583), false, "Mr. Monica Helmer Kuvalis", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(2583) },
                    { "068fe362-9be4-4ce2-84dc-95912d0d8fdf", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(1687), false, "Juvenal Reinger", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(1687) },
                    { "112148cc-9f86-46a7-84e2-194a48250606", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(8911), false, "Raquel Crist", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(8911) },
                    { "7c5b129b-0eb6-498a-8e22-e2eb8951a21a", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(9794), false, "Gordon Feeney V", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(9795) },
                    { "a6ab2db2-5d6a-4b0a-bdad-596a0239918b", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(673), false, "Nola Turner", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(674) },
                    { "c2ef41ed-f0d0-4c0a-acb1-39ea65bcea3f", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(7780), false, "Lacy Witting", new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(7785) },
                    { "de466ad2-9499-41ca-b910-eeb105832d75", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(7674), false, "Mr. Kip Gerlach DDS", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(7675) },
                    { "f0176c71-a172-4f69-8b3c-11844897561c", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(5140), false, "Alfred Hintz", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(5141) },
                    { "f34f040f-4218-4984-8c1e-b38739622e51", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(6018), false, "Dr. Zackery Aliza Hegmann MD", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(6018) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "0868199b-d1ec-4dfe-bdcd-9e450fbea376", null, "Illo libero repudiandae neque sed totam. Possimus accusantium at dolorem. Ipsum quas ea maiores eum id alias quod. Est molestias perspiciatis nulla eius nostrum qui. Error distinctio est accusantium et. Praesentium sunt libero sed pariatur ab voluptas expedita porro explicabo.", new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(2799), "Aut quibusdam qui non hic culpa in optio.", false, "Lemuel Gibson", 991867L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(2803) },
                    { "22be2903-4d8a-4a98-a96f-8076ccc2c3a0", null, "Vitae accusamus deserunt pariatur quibusdam quia aut delectus. Maxime ut dolores recusandae ea. Incidunt ipsam nihil quae illo.", new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(1755), "Nam eum sint odio dolorum quia ea consequatur.", false, "Prof. Paul Jody Legros I", 207439L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(1756) },
                    { "26b4f261-63cc-4fc4-ab1c-c00b5300eb60", null, "Et molestias sunt sed animi fugiat optio accusamus. Et alias aut praesentium aperiam. Eveniet aut voluptatem ipsa. Eveniet optio eos molestiae quisquam. Earum et quia esse perferendis minus quaerat in incidunt. Dolorem et voluptas et aperiam.", new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(8833), "Nihil ea ut reprehenderit perspiciatis.", false, "Chester Hammes", 744210L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(8837) },
                    { "364801c7-0094-496f-a50a-7b8c3097a466", null, "Est rem incidunt libero voluptatem voluptas qui et. Commodi et dolore consectetur quam id tenetur dolorum dicta. Quia laboriosam quisquam aut aut harum corporis ipsum.", new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(5213), "Laboriosam iusto recusandae voluptates.", false, "Miss Jesse Garnet Bashirian", 435045L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(5218) },
                    { "492ae5ab-30c3-42f4-af19-346ba920366c", null, "Qui et nostrum alias velit et sit numquam eos. Ullam deleniti qui et repellat id ut consequuntur reprehenderit sequi. Explicabo quisquam velit quibusdam est.", new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(7921), "Soluta ut natus nulla neque.", false, "Ottis Veum", 411331L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(7924) },
                    { "7b83b6e8-462c-4f74-bb66-67d6d2864d3f", null, "Mollitia quia dignissimos aut nostrum ducimus ullam sunt dolorum. Et nisi laborum repudiandae ullam voluptas aut. Voluptatem voluptate sequi eum.", new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(6830), "Et dolorum sunt voluptatem.", false, "Miss Dashawn Coby Kris", 110972L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(6833) },
                    { "a2c5eaf2-c8be-48e5-950e-5f04964f4c51", null, "Alias atque expedita soluta. Ipsam facilis sed et qui suscipit dolorem aut et. Animi quia et dolorem eum eveniet dolorum non.", new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(8593), "Doloribus cupiditate facilis soluta labore odit voluptates ut.", false, "Eusebio Oberbrunner II", 324744L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(8593) },
                    { "b4707bd1-2047-43f3-a08a-a607e7b6fb01", null, "Voluptas excepturi nam accusantium eveniet libero. Consequatur laborum tempore occaecati repellat maiores qui quos excepturi magnam. Sapiente explicabo aliquam asperiores est illum voluptate fuga.", new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(714), "Et mollitia eius sint et dolor voluptatibus ut.", false, "Ms. Eliza Marks", 581715L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(716) },
                    { "c61e019f-78cd-4f13-8706-80c9f60ae148", null, "Ipsa ipsa consequuntur illum qui in. Molestiae laboriosam commodi sunt nihil maxime non. Cupiditate dolore vel doloremque culpa qui repudiandae sed necessitatibus. Dolor repudiandae omnis odit illo et et. Delectus repellat omnis et et. Vero quia dignissimos provident quae non.", new DateTime(2023, 3, 25, 12, 5, 16, 618, DateTimeKind.Utc).AddTicks(725), "Cumque corrupti qui voluptatem rerum saepe consequatur sit quia.", false, "Kianna Batz", 113076L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 618, DateTimeKind.Utc).AddTicks(726) },
                    { "e972b27f-b387-4802-893d-250fdc401d67", null, "Consequatur voluptate quos odio. Qui tempore ipsam minima quia expedita. Explicabo perspiciatis porro odio voluptates ipsa dignissimos accusantium. Itaque a qui sunt quod. Et et quaerat quis hic non nisi dolores consequuntur.", new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(3961), "Iure excepturi ut sunt accusantium aut sequi alias.", false, "Candida Feest", 716698L, 1, 0L, new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(3967) }
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
