using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "c3d7a70d-1a07-4852-a0bc-be42723c8965");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "4d3046b3-c41b-4a40-834b-003cc978eca0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "b14fb576-3728-4e51-92d0-fc1f5c280592");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdd1ef71-55f4-42ba-a995-a00f4149d6c2", "d663c150-b73f-4895-82c9-d444e0749270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86182564-0e7c-4ce6-ace7-4a75a01fd414", "5930a6dd-f615-4a93-97ba-72d8dc945f8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3d9a5f7-c545-45de-9b38-9d5a967ab3a1", "7e12d397-068c-47a4-aec6-413a7cb99f98" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "00432e63-f251-4c7c-9ce3-1f1668fe7d84", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(8436), false, "Mr. Mathias Johnson III", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(8436) },
                    { "1dfda534-df0f-4769-bc51-87aa15022006", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(2385), false, "Dr. Terrance Cremin", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(2385) },
                    { "4bcc28f8-9e60-4fe6-9773-aaa74e39a9a1", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(3294), false, "Cielo Reichel", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(3295) },
                    { "77b3109c-03fa-418c-8d17-b4f850d64a4b", new DateTime(2022, 12, 30, 15, 53, 19, 360, DateTimeKind.Utc).AddTicks(7963), false, "Berta Stanton", new DateTime(2022, 12, 30, 15, 53, 19, 360, DateTimeKind.Utc).AddTicks(7965) },
                    { "835efcfe-07e0-4847-a989-dc11099837d9", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(9733), false, "Miss Kaitlyn Murray", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(9734) },
                    { "926651fa-987a-42c3-b5fe-a0ccddadb6e4", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(6866), false, "Zakary Corkery", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(6867) },
                    { "add9428d-cf08-40e3-9305-f22ba8ae2b13", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(636), false, "Lavern Johnson", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(636) },
                    { "be839626-78bb-46ae-878d-a1cc22bf0a5c", new DateTime(2022, 12, 30, 15, 53, 19, 360, DateTimeKind.Utc).AddTicks(9462), false, "Mitchell Grimes", new DateTime(2022, 12, 30, 15, 53, 19, 360, DateTimeKind.Utc).AddTicks(9462) },
                    { "e6261521-ecd9-4151-915e-0a7041261cfb", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(4957), false, "Miss Talia Spinka", new DateTime(2022, 12, 30, 15, 53, 19, 361, DateTimeKind.Utc).AddTicks(4957) },
                    { "f3a59264-9c7c-4b88-afee-c54d70fbaf79", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(1066), false, "Cody Fisher", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(1067) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "247ed036-4a0b-40aa-b161-e5404cf54f62", null, "Deserunt totam ullam laudantium ipsam aut maxime et distinctio. Consequatur nobis id dolorum aut aut ratione. Ipsam autem a est consequatur voluptas. Natus sapiente quia vero. Ab exercitationem dignissimos doloribus aut magnam beatae qui. Quae ut occaecati nihil ut.", new DateTime(2022, 12, 30, 15, 53, 19, 369, DateTimeKind.Utc).AddTicks(6928), "Est soluta placeat saepe ad et id.", false, "John Bergstrom", 509934L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 369, DateTimeKind.Utc).AddTicks(6929) },
                    { "57bb633e-684a-4763-a89a-ea1e6e3cfde9", null, "Impedit ea modi commodi reiciendis nobis. Asperiores aut dolorem optio molestias soluta officiis eos modi. Magnam adipisci a quasi nisi voluptas et molestias dolores. Earum quaerat molestiae sed. Quaerat veritatis qui quo et illum cumque quam. Voluptatibus eveniet dolor aperiam fugit quia dignissimos est.", new DateTime(2022, 12, 30, 15, 53, 19, 367, DateTimeKind.Utc).AddTicks(1472), "Consequatur exercitationem repudiandae officiis animi ratione vero.", false, "Bo Gusikowski", 198893L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 367, DateTimeKind.Utc).AddTicks(1473) },
                    { "68f52e9d-be34-45c5-8234-cd319db6857d", null, "Beatae reiciendis est doloremque porro eum vel laboriosam animi sit. Voluptatum fugit asperiores velit odit modi facere voluptatum. Voluptatem sit numquam dolorum sint consequatur consequatur et ducimus. Doloremque et fugiat expedita consequuntur veritatis non.", new DateTime(2022, 12, 30, 15, 53, 19, 363, DateTimeKind.Utc).AddTicks(3708), "Fugiat soluta cupiditate aut maxime eligendi eum.", false, "Carmelo Mayer", 396098L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 363, DateTimeKind.Utc).AddTicks(3710) },
                    { "7ae54028-290b-4940-bb06-5af4a1e7c264", null, "Fugit omnis voluptas modi. Sed commodi non temporibus. Modi quas assumenda aut voluptas dicta cum. Corporis reprehenderit commodi placeat rerum ut et porro. Nobis libero libero iure. Enim rerum similique dolore beatae eos aliquid unde.", new DateTime(2022, 12, 30, 15, 53, 19, 364, DateTimeKind.Utc).AddTicks(6517), "Ut dolor veniam eum et beatae ea quaerat repellendus sed.", false, "Reese Hayes", 916232L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 364, DateTimeKind.Utc).AddTicks(6518) },
                    { "9bde741d-fba6-4ebb-8c48-a961468b6ddb", null, "Consequatur qui officia dolorem tenetur consequatur nobis voluptate. Odit sed labore labore ut earum soluta alias aut quo. Ipsa non qui ipsa magnam eius tempore nesciunt ducimus iste.", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(3733), "Quo eligendi omnis et est ratione ratione perferendis amet.", false, "Lennie Koelpin", 737823L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(3733) },
                    { "9fbc1664-6fdf-40f8-843e-59f6ed0cc7af", null, "Labore voluptas ut iure error repellendus dolor quo. Et pariatur dignissimos et et. Sint molestiae est omnis eos ut numquam est sit magni. Ea exercitationem nostrum ipsa fugit qui pariatur repellendus. Et error sit ipsam veritatis. Incidunt iste atque odit ab veritatis veritatis nihil.", new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(9055), "Laborum quos officia eaque.", false, "Lane Turner", 529023L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 362, DateTimeKind.Utc).AddTicks(9056) },
                    { "c79d3654-b629-4a4c-93b6-e1be9774475d", null, "Repellat provident ipsa iusto perspiciatis rerum tenetur. Est laborum ut suscipit illo quia quis velit. Voluptates quia at alias est aut quaerat voluptates.", new DateTime(2022, 12, 30, 15, 53, 19, 364, DateTimeKind.Utc).AddTicks(2686), "Eum occaecati ab accusantium numquam qui.", false, "Mae Morissette", 154140L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 364, DateTimeKind.Utc).AddTicks(2687) },
                    { "d3b192f6-6feb-446a-9c41-647f1718151f", null, "Eligendi enim non perspiciatis repudiandae atque necessitatibus et harum. Recusandae id omnis corrupti modi amet in delectus. Eum similique sapiente inventore perspiciatis sint voluptas dolor minima illo. Voluptatem est totam ea ab similique. Sit saepe et incidunt.", new DateTime(2022, 12, 30, 15, 53, 19, 368, DateTimeKind.Utc).AddTicks(5982), "Et voluptas cumque sed asperiores dignissimos sint iusto voluptatem.", false, "Hellen Weimann", 634056L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 368, DateTimeKind.Utc).AddTicks(5983) },
                    { "e70712f1-bc1f-4292-8c02-ae7badf1a9b0", null, "Velit placeat non autem et unde est vel. Atque rerum ea ea alias est quas et qui magnam. Numquam aut quia soluta quia quia magni non consequatur. Dolor eligendi quia incidunt odit nisi et quia enim quibusdam.", new DateTime(2022, 12, 30, 15, 53, 19, 363, DateTimeKind.Utc).AddTicks(8223), "Atque est id natus et praesentium eveniet sit.", false, "Louisa Wilderman", 585122L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 363, DateTimeKind.Utc).AddTicks(8224) },
                    { "f5b3cc90-e0e5-4f41-af5c-78530ca13809", null, "Saepe a eos voluptas voluptatem eum. Voluptatibus quia provident incidunt consequatur quae ut iste consectetur repellat. Assumenda harum et incidunt mollitia est voluptatem. Aut sequi molestiae ducimus inventore ratione aut eius et. Quia possimus impedit voluptatem ratione nulla est nesciunt non aperiam.", new DateTime(2022, 12, 30, 15, 53, 19, 365, DateTimeKind.Utc).AddTicks(1322), "Tempore qui possimus quam facere autem.", false, "Dr. Abbey Nolan Rohan II", 979392L, 1, 0L, new DateTime(2022, 12, 30, 15, 53, 19, 365, DateTimeKind.Utc).AddTicks(1323) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "00432e63-f251-4c7c-9ce3-1f1668fe7d84");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1dfda534-df0f-4769-bc51-87aa15022006");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4bcc28f8-9e60-4fe6-9773-aaa74e39a9a1");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "77b3109c-03fa-418c-8d17-b4f850d64a4b");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "835efcfe-07e0-4847-a989-dc11099837d9");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "926651fa-987a-42c3-b5fe-a0ccddadb6e4");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "add9428d-cf08-40e3-9305-f22ba8ae2b13");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "be839626-78bb-46ae-878d-a1cc22bf0a5c");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "e6261521-ecd9-4151-915e-0a7041261cfb");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "f3a59264-9c7c-4b88-afee-c54d70fbaf79");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "247ed036-4a0b-40aa-b161-e5404cf54f62");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "57bb633e-684a-4763-a89a-ea1e6e3cfde9");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "68f52e9d-be34-45c5-8234-cd319db6857d");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7ae54028-290b-4940-bb06-5af4a1e7c264");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9bde741d-fba6-4ebb-8c48-a961468b6ddb");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9fbc1664-6fdf-40f8-843e-59f6ed0cc7af");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "c79d3654-b629-4a4c-93b6-e1be9774475d");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "d3b192f6-6feb-446a-9c41-647f1718151f");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "e70712f1-bc1f-4292-8c02-ae7badf1a9b0");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "f5b3cc90-e0e5-4f41-af5c-78530ca13809");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

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
    }
}
