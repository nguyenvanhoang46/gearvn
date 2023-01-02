using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Update_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "AspNetRoles",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "a0745c84-46da-4b2b-93eb-1a1a721fa9c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "f33791e4-e199-4302-9122-d07a8d0e7ac8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "33bce3f2-3451-46c2-918a-264a8277ac10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2d9327f-c09b-4de6-ac41-26b9b4dccb7a", "385a3b7e-664f-41d7-b940-b87923de3341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c65c4a6e-6ecc-44b4-ad23-b57c0342be02", "d80841d7-3a6b-4a7a-b566-b5744ad289c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16206622-4876-44bb-855a-fb6b1bd0674f", "d23bdc82-f7c3-4af3-81a2-3a57a479166b" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "28b77db2-31fe-4f92-bf5a-c461a9c16c91", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(8617), false, "Foster Kunde", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(8617) },
                    { "3673056f-b803-43a0-a8c2-bf47a3c7f259", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(9515), false, "Dr. Dustin Wuckert DVM", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(9516) },
                    { "5625d8a6-6846-411b-810b-4bac6e72e160", new DateTime(2023, 1, 2, 14, 28, 4, 753, DateTimeKind.Utc).AddTicks(6660), false, "Dewayne Kshlerin", new DateTime(2023, 1, 2, 14, 28, 4, 753, DateTimeKind.Utc).AddTicks(6662) },
                    { "58e55eb6-fdf8-48cb-a130-dfe7a7186750", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(5221), false, "Ms. Kadin Kylee Dickens", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(5221) },
                    { "79636609-6181-471d-9aec-d7c071a77156", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(4314), false, "Prof. Tod Roob PhD", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(4314) },
                    { "9bcf978c-76a2-471d-a453-848ac6f87791", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(510), false, "Mr. Jeffrey Gregoria Morissette", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(510) },
                    { "9f6a2c53-13b1-46bd-a490-6c0c7814e83a", new DateTime(2023, 1, 2, 14, 28, 4, 753, DateTimeKind.Utc).AddTicks(7997), false, "Prof. Kellie Cheyanne Dickens IV", new DateTime(2023, 1, 2, 14, 28, 4, 753, DateTimeKind.Utc).AddTicks(7997) },
                    { "aac2ff7e-6a76-4f1d-a301-78bc1c679ec8", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(6881), false, "Monserrate Vernie Reynolds MD", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(6881) },
                    { "c88f594e-8a5c-45ee-bce6-19061590a9eb", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(3321), false, "Prof. Katarina Stokes", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(3322) },
                    { "f2129d5d-eeed-4d42-899c-f64aa82fbe46", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(2373), false, "Stanford Lubowitz", new DateTime(2023, 1, 2, 14, 28, 4, 754, DateTimeKind.Utc).AddTicks(2373) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "13eda561-16c7-4f68-8ccb-3fad2e002c3d", null, "Sit unde veritatis ex voluptatibus molestiae corrupti quia dignissimos. Rerum tenetur magnam alias in voluptatibus sit nulla. Tempore rem quaerat est pariatur. Earum ut modi voluptatibus.", new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(8263), "Sunt aspernatur voluptates quibusdam sed delectus architecto magnam.", false, "Elwyn Bernhard", 587129L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(8264) },
                    { "3e840e3e-50d7-4b15-b048-27aac13f8074", null, "Debitis sit corporis laboriosam impedit voluptas est sed. Temporibus molestiae magnam culpa minus quibusdam iste autem. Explicabo doloribus corrupti sit quae quo sit molestiae laborum.", new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(4863), "Alias et laboriosam incidunt deleniti sed et.", false, "Maximillia Altenwerth", 439487L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(4864) },
                    { "5289fd92-c3f4-407f-8b1c-375afa3453e1", null, "Odio iusto fuga pariatur reprehenderit repellendus. Nisi dolorem neque porro voluptas. Ut laboriosam et iusto quo voluptate sit. Occaecati totam voluptatum autem.", new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(4279), "Aut minima ut animi adipisci aut voluptatem.", false, "Liliane Crist", 360642L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(4279) },
                    { "56bc8b92-23c8-4053-8f08-84843cea19eb", null, "Reiciendis est qui molestiae quo animi quos. Atque qui ratione hic dolorem aut qui cum nisi quidem. Ab ut impedit natus temporibus eum eaque odit. Sunt ipsa facilis molestiae doloribus repellat ipsum cumque asperiores hic. Ut magnam dolore laboriosam voluptate ullam.", new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(7177), "Neque ullam unde reiciendis.", false, "Abbey Eldon Blanda IV", 145357L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(7177) },
                    { "58edc340-641c-4e77-ba26-0b84ebc08e3a", null, "Accusamus et fugit voluptatem quibusdam ad perspiciatis veritatis. Ut delectus expedita velit harum voluptas molestiae at ex. Et consequatur et ea illum incidunt. Iusto architecto dolores magni harum non. Debitis qui id et magnam.", new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(1904), "Cupiditate et magnam esse minima suscipit eum voluptatem illum.", false, "Zane Gleason IV", 934713L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(1906) },
                    { "685d73bf-3de5-4902-a4a3-fd8b46a9a45c", null, "Quia vitae consequatur eveniet ducimus eveniet repudiandae pariatur. Qui nisi et dolores. Rerum aliquid placeat ut modi optio ipsa. Quidem ut in rem illum. Quasi et eos dolor. Ipsam commodi quasi quos omnis mollitia quam itaque non.", new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(391), "Consequatur omnis et reiciendis exercitationem maxime cum.", false, "Chris Cole", 479781L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 755, DateTimeKind.Utc).AddTicks(391) },
                    { "697a111d-bb33-4d61-8f07-153529bdbb81", null, "Ratione ut possimus fugit et esse perferendis ipsa ratione dolores. Assumenda et et enim. Ipsa eos et dolores omnis. Beatae minus optio eligendi et excepturi officia. Inventore illum qui expedita repellat sed nesciunt distinctio perferendis.", new DateTime(2023, 1, 2, 14, 28, 4, 758, DateTimeKind.Utc).AddTicks(1259), "Omnis enim aut delectus voluptas itaque consequatur quo.", false, "Ms. Chanelle Gislason MD", 527782L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 758, DateTimeKind.Utc).AddTicks(1259) },
                    { "981a4584-4383-4772-bea3-a4614d1c8ee3", null, "Nesciunt iure est placeat in architecto vero necessitatibus qui harum. Labore in repudiandae ut magni qui recusandae aliquam. Voluptatibus quod ipsa magnam labore similique quod. Quia quia et laboriosam molestiae.", new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(1343), "Eaque ducimus rem quisquam facilis sit esse autem totam.", false, "Ally Carroll", 721989L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(1344) },
                    { "be9395cb-df11-4492-8456-9c6649fb3f54", null, "Possimus quibusdam officia in minus iusto ab atque. Quas omnis alias voluptatibus. Aliquid tenetur reiciendis et magnam beatae saepe.", new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(7885), "Id ea blanditiis voluptatem recusandae eum sunt qui natus.", false, "Bud Bergstrom", 505216L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 757, DateTimeKind.Utc).AddTicks(7885) },
                    { "e7af37e1-edca-4db9-a1e0-ea348fbe85d0", null, "Animi possimus accusamus fugit veritatis. Inventore et vel est nam. Quia explicabo mollitia omnis similique nihil occaecati.", new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(5712), "Amet dolorum earum id id quibusdam minus.", false, "Christina Fahey", 516124L, 1, 0L, new DateTime(2023, 1, 2, 14, 28, 4, 756, DateTimeKind.Utc).AddTicks(5713) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "28b77db2-31fe-4f92-bf5a-c461a9c16c91");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3673056f-b803-43a0-a8c2-bf47a3c7f259");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5625d8a6-6846-411b-810b-4bac6e72e160");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "58e55eb6-fdf8-48cb-a130-dfe7a7186750");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "79636609-6181-471d-9aec-d7c071a77156");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "9bcf978c-76a2-471d-a453-848ac6f87791");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "9f6a2c53-13b1-46bd-a490-6c0c7814e83a");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "aac2ff7e-6a76-4f1d-a301-78bc1c679ec8");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c88f594e-8a5c-45ee-bce6-19061590a9eb");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "f2129d5d-eeed-4d42-899c-f64aa82fbe46");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13eda561-16c7-4f68-8ccb-3fad2e002c3d");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3e840e3e-50d7-4b15-b048-27aac13f8074");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5289fd92-c3f4-407f-8b1c-375afa3453e1");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "56bc8b92-23c8-4053-8f08-84843cea19eb");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "58edc340-641c-4e77-ba26-0b84ebc08e3a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "685d73bf-3de5-4902-a4a3-fd8b46a9a45c");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "697a111d-bb33-4d61-8f07-153529bdbb81");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "981a4584-4383-4772-bea3-a4614d1c8ee3");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "be9395cb-df11-4492-8456-9c6649fb3f54");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "e7af37e1-edca-4db9-a1e0-ea348fbe85d0");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AspNetRoles",
                newName: "IsDelete");

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
    }
}
