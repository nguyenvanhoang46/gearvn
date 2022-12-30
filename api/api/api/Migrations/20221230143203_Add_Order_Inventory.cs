using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Add_Order_Inventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "046249b3-7e4d-4a05-ad3a-efe1fa54f3b6");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1f7f2d3e-dfbc-4669-8d0f-0f9f6a8c6919");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "250d1a43-afb4-4b09-94fa-776e1bb531eb");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2bc7858f-d35a-4da7-be79-0e77912f7194");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2be6f46b-2f6c-494e-9734-1f1f0e49ee34");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "353a134a-076b-4df8-8ab5-93ec30cf6608");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "37b579a6-fbdf-4f85-85a1-85a90fa7f020");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "386d32ae-3c53-4db1-9452-a95e4e1e4bc6");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "7ac24e7e-703e-4616-9a7b-a071d03a15bd");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c6e33434-cdc4-4031-98ad-473ce68b0b79");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "0250efd3-de7f-4253-99aa-240ffd8bb4ae");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "0aff9e69-fd7c-4f65-9fb5-cf02e0ace38a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "0c5ecfc9-2e67-4709-9858-572b4007d07e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "40a1bd7d-f011-455c-b8d4-2b5a3c7169d9");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "56639b8a-46f6-45f9-8e50-3fb2ae3f7290");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8922a27b-5d4c-41b6-a9f3-92307b4e5956");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9c1043b8-9702-40e9-a813-c7730d4dd042");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "c0040539-3dcc-49ed-86c5-e0006f043b1c");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "c5f02cba-30be-4bc9-af41-e610e47d22f5");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "e70805b1-1a8d-42cd-ada2-706fdcea6fc1");

            migrationBuilder.AddColumn<int>(
                name: "OrderCompletionType",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "7b839d19-ac5c-480f-b378-d45445e35cf3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "9e1b1a3a-f39e-4844-8017-8c32e395ec19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "5e5a6786-a46c-4b52-a686-6eb234380460");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07206af6-aff5-4ea7-9fdb-e6f557122044", "9d69bd75-ca33-4f4a-ab13-68968a3bb22c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f40c3547-5014-4122-9347-a7448f10049e", "c7714e28-dd92-4921-a2cd-00a284347ebb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87976657-1a1b-4da1-8afe-887e854d17c4", "5f847ad5-87e7-4e6e-ad09-24aec5d17164" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2224eb45-9beb-4b0f-b95e-c7bfe654f2dd", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(2971), false, "Madison Monahan", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(2971) },
                    { "2540409b-319a-43c1-8e3d-c0c90a3a39e2", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(8074), false, "Nola Sipes", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(8074) },
                    { "261a5248-5170-456a-8146-a90099f71867", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(5634), false, "Faustino Kling DVM", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(5634) },
                    { "36573948-d1f1-4cc3-91b9-912866a802aa", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(1946), false, "Chandler Ryan", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(1946) },
                    { "774b79c2-fccf-4447-bb31-cb61afacae60", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(9031), false, "Dell Crooks", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(9031) },
                    { "7bcae963-2fd6-4d21-a0ac-3dcd87f82d22", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(4522), false, "Judge Medhurst", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(4523) },
                    { "a93d7cfd-c91c-4117-8229-62b3caaaa0ce", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(3921), false, "Monty Wyman", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(3921) },
                    { "c3b4daef-fe81-4689-8491-17dd693223bc", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(2493), false, "Mr. Darrel Swift", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(2494) },
                    { "cec4412b-f59a-472a-b561-d44884160d1c", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(7001), false, "Aditya Metz", new DateTime(2022, 12, 30, 14, 32, 3, 123, DateTimeKind.Utc).AddTicks(7001) },
                    { "f9e2890c-2a82-4e56-8cc2-c7b982a25481", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(39), false, "Mrs. Rocky Marlon Batz DVM", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(39) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "0f8d0da7-6efd-46cd-9575-a644b76a922f", null, "Reiciendis in dolor voluptas voluptatem vero earum molestiae consequatur. Itaque nostrum quaerat velit vel esse aut suscipit. In nulla minima minima in quibusdam et ullam placeat. Necessitatibus rerum dolorem et aut repellat neque. Eius quia beatae quo ea.", new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(941), "Laborum aut tempore sed tempora.", false, "Miss Concepcion Ledner", 303601L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(942) },
                    { "23454a4b-2cf0-44fd-91e8-39952f740983", null, "Doloribus tempora mollitia perferendis tempore. Perspiciatis illum vitae mollitia blanditiis voluptas quod recusandae. Quas expedita consequatur voluptas maiores sed. Aut voluptatem voluptas architecto.", new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(9887), "Est aperiam eum qui neque sit dolore.", false, "Miss Savanah Dariana Reynolds", 447606L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(9888) },
                    { "319562dd-f352-44fb-b792-44341f40f35e", null, "Dolores tempora sed ex earum. Nobis dolorem quo culpa commodi et odio. Rem quia ea inventore quia consequatur rem sint. Et omnis ut vero molestias tempora excepturi dolores. Ut commodi recusandae ut veritatis aspernatur. Et quam eum eligendi aut ipsa ut architecto.", new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(4895), "Labore cum autem neque occaecati mollitia rem recusandae.", false, "Mrs. Camilla Cayla Rosenbaum", 410010L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 124, DateTimeKind.Utc).AddTicks(4895) },
                    { "547ae8b8-e61f-42ae-b9fe-91c3d30aef94", null, "Assumenda sit libero esse ea placeat qui quam nisi. Dolore aut voluptatem similique sint officiis odit et eos optio. Sed quibusdam qui voluptas amet cupiditate molestiae et repellat dicta. Est eum fuga et. Non labore et architecto dolore est in.", new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(4972), "Amet voluptatum voluptatibus voluptatem aperiam quia.", false, "Mrs. Elsa Parker Swaniawski PhD", 502252L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 125, DateTimeKind.Utc).AddTicks(4972) },
                    { "62fa8be3-df63-42d4-8ce3-1ab52bf5efe6", null, "Dolorum aperiam voluptate hic esse molestiae eum. Sit qui omnis laudantium quisquam aut sed tempora id. Mollitia iste fugiat omnis quam sit est et. Saepe eaque possimus beatae numquam qui.", new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(304), "Aut unde et cum animi voluptates a praesentium dolorem.", false, "Miss Alexandrea Leffler", 295286L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(304) },
                    { "71271579-88af-420c-807b-86b423e4e2a3", null, "Enim vel aut voluptatem sit. Debitis quis inventore sed deleniti necessitatibus similique ex voluptatem. Cupiditate ut est porro deleniti. Veniam vel id sunt itaque quo labore id.", new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(3705), "Possimus perspiciatis praesentium aut aliquam provident voluptas iste soluta.", false, "Prof. Letitia Terry", 792524L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(3705) },
                    { "7cfc21f7-daea-4032-ab5e-afbf33df0416", null, "Quia cumque minus cum ad cum nihil optio minima omnis. Et itaque et nemo minima nisi doloremque inventore. Eum autem nemo eos a laborum. Unde corporis laudantium ut voluptatem pariatur.", new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(6899), "Eos maxime enim nobis rerum aut sunt debitis facilis.", false, "Donald Kulas", 680874L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 127, DateTimeKind.Utc).AddTicks(6900) },
                    { "853d6b97-8c2c-4711-ab59-cdd01765c3ce", null, "Dolorem quis ea et voluptas sit rem. Impedit qui aut cum consequuntur aut quas. Facere ut autem dignissimos voluptatem dolorum dolor. Rerum et totam qui. Perferendis odio dolorem dolor nihil sit quidem consectetur dolores. Voluptatem cumque ullam nam omnis qui dignissimos placeat excepturi.", new DateTime(2022, 12, 30, 14, 32, 3, 126, DateTimeKind.Utc).AddTicks(3611), "Incidunt ad iure quia sunt magnam.", false, "Glen Hamill", 290868L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 126, DateTimeKind.Utc).AddTicks(3612) },
                    { "bf525c35-7a02-4bbc-9554-4e1f87ad2640", null, "Enim soluta rerum aut fugiat in culpa illo ut aut. Eos explicabo debitis molestiae quisquam perferendis ab reprehenderit eveniet. Fuga numquam eius dolores. Excepturi incidunt aut nisi. Omnis et quo soluta suscipit aut quaerat enim. Doloribus cumque eveniet consequatur consequatur vero aut rerum pariatur.", new DateTime(2022, 12, 30, 14, 32, 3, 128, DateTimeKind.Utc).AddTicks(373), "Culpa dolor blanditiis est id eaque sed velit.", false, "Prof. Raul Dach", 211772L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 128, DateTimeKind.Utc).AddTicks(373) },
                    { "d81a2091-4732-44fd-834b-709dd4aed0dd", null, "Sunt modi deserunt facere rerum totam non sint tenetur consequatur. Labore velit vero magnam. Et dolor quod eos.", new DateTime(2022, 12, 30, 14, 32, 3, 126, DateTimeKind.Utc).AddTicks(7734), "Et molestiae rerum ut sit quod dolore ea rerum.", false, "Merl Satterfield III", 580042L, 1, 0L, new DateTime(2022, 12, 30, 14, 32, 3, 126, DateTimeKind.Utc).AddTicks(7735) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2224eb45-9beb-4b0f-b95e-c7bfe654f2dd");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2540409b-319a-43c1-8e3d-c0c90a3a39e2");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "261a5248-5170-456a-8146-a90099f71867");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "36573948-d1f1-4cc3-91b9-912866a802aa");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "774b79c2-fccf-4447-bb31-cb61afacae60");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "7bcae963-2fd6-4d21-a0ac-3dcd87f82d22");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "a93d7cfd-c91c-4117-8229-62b3caaaa0ce");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3b4daef-fe81-4689-8491-17dd693223bc");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "cec4412b-f59a-472a-b561-d44884160d1c");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "f9e2890c-2a82-4e56-8cc2-c7b982a25481");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "0f8d0da7-6efd-46cd-9575-a644b76a922f");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "23454a4b-2cf0-44fd-91e8-39952f740983");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "319562dd-f352-44fb-b792-44341f40f35e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "547ae8b8-e61f-42ae-b9fe-91c3d30aef94");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "62fa8be3-df63-42d4-8ce3-1ab52bf5efe6");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "71271579-88af-420c-807b-86b423e4e2a3");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7cfc21f7-daea-4032-ab5e-afbf33df0416");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "853d6b97-8c2c-4711-ab59-cdd01765c3ce");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "bf525c35-7a02-4bbc-9554-4e1f87ad2640");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "d81a2091-4732-44fd-834b-709dd4aed0dd");

            migrationBuilder.DropColumn(
                name: "OrderCompletionType",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "48231ff4-2bb9-4ce3-ad5e-0808cb3d3a42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "1d37f90a-fcbf-4e1f-b13a-216e962e17c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "efe42aad-1448-4740-bae2-146dbd3c4e1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b3dc9c7-9274-4bd3-9fd2-fb587cde0435", "4f9b8c16-0019-42d2-942f-94460e0b151b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa9eb516-cf2b-4ee0-a353-fb20272973f3", "141ae25e-f808-47c0-839c-d1ec2f8a18af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ecfb82d-6ec1-45dd-953a-ef4b93046d15", "9833f343-a286-49d8-afc4-15c956e75133" });

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
        }
    }
}
