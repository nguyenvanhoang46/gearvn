using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Update_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "057c7357-bb76-4391-acf5-a5c53dad78cd");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1ae30045-98d5-488f-bc88-e1fd1919fb59");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "254bea6c-2bc5-4ec6-9899-4e3b08533a3d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "26a35f16-7798-4cde-8f65-4393dbe4edad");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3c572b81-105d-40ea-9897-b7d03336a674");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "8b67e980-44a0-437c-b2c1-43bd87e203bc");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "a9fe18a3-4138-4371-bcf4-f2431e735c9e");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ca93d851-7d02-4de0-bc82-1abbb1b1dc7d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ce14eda4-cb0c-4379-b13d-114a98317d91");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "e90de408-a3cc-4c48-b753-d9641afea031");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "01c4d110-ec55-442f-87b9-5851138149ee");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "095be80d-f11c-46aa-a7fc-6bf1ee698fa6");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2d3637cf-f1b3-4643-91a9-4c388a93c7ff");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "56bbacbd-2225-4612-9723-bab7fd93f8a2");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5c868d34-37c8-48b7-8d09-54fa86c1a289");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "870aa1e2-3b2c-4021-b35a-52f49ee14f8a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8fcf0c40-9769-47ba-b816-48cdcb2eeaa4");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "92c37962-ec95-4443-a86d-a0a077b26926");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "f1422ece-ad6c-4877-83a6-44e46abe016e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "f56bf040-6fcd-4ad3-b782-f572d09d3b15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "e7564feb-b9a4-4a9c-99ac-029e361b2fe1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "e81f15a1-028f-4d80-a87d-5061facca41e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "634ccd0b-c551-40e7-9e26-97c3ca2562a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "538854ad-3de1-4b08-a74c-121ecaa8c8ff", "9efb6f9e-1f2c-4938-a5df-bd1ad1a46cde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d931e75-fbed-4556-8719-589e96f124a4", "933cc1c0-de5e-4915-bbb9-653fcfbe0fbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4482f5f7-c0d0-4c6b-ad3c-d80f7e5edfba", "5650055a-f24b-4305-8eaa-0fe73e6bda65" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "028b0e3a-ee00-429b-86b6-90ab6b5c3e43", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(7526), false, "Mr. Rashawn Ullrich Jr.", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(7527) },
                    { "319c2c3c-316d-479b-b661-5cf9baad9589", new DateTime(2023, 2, 5, 12, 27, 29, 777, DateTimeKind.Utc).AddTicks(7626), false, "Ms. Joey Kenna Lang MD", new DateTime(2023, 2, 5, 12, 27, 29, 777, DateTimeKind.Utc).AddTicks(7628) },
                    { "3c9fc0ee-3ef9-44a0-8116-a10c961a4ecf", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(6211), false, "Johnathon Blanda V", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(6211) },
                    { "4acd12e9-4170-4e19-90b1-eac262dddc3d", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(8819), false, "Santino Jerde", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(8820) },
                    { "5c5d64e9-4189-4534-a3b5-314883f90adb", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(404), false, "Prof. Hudson Cesar Rolfson Sr.", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(405) },
                    { "97533320-15b0-4d6b-bc3e-c3f956c2cbfe", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(2012), false, "Leonel Howell", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(2013) },
                    { "a6122378-04b4-4b16-b460-4bb37c030090", new DateTime(2023, 2, 5, 12, 27, 29, 777, DateTimeKind.Utc).AddTicks(9453), false, "Leola Brown", new DateTime(2023, 2, 5, 12, 27, 29, 777, DateTimeKind.Utc).AddTicks(9454) },
                    { "b09f4adf-2aa8-4068-8376-5b89e912dd29", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(3784), false, "Derek Parker", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(3784) },
                    { "c1b6c011-ba5a-4b75-9017-2899c7360736", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(2881), false, "Nolan Ebert", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(2881) },
                    { "d4c4b85f-a8ad-4f53-a46f-f21ba077e942", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(4959), false, "Art Walker", new DateTime(2023, 2, 5, 12, 27, 29, 778, DateTimeKind.Utc).AddTicks(4960) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "Quantity", "SalePrice", "UpdatedAt" },
                values: new object[,]
                {
                    { "230f777e-907b-419c-9a8a-4e3dce9d169b", null, "Nam veritatis totam quaerat. Vel id velit id. Magnam pariatur mollitia voluptatem et eligendi. Dolor sunt dolore error laboriosam et officiis ut soluta itaque.", new DateTime(2023, 2, 5, 12, 27, 29, 781, DateTimeKind.Utc).AddTicks(3715), "In quos mollitia hic dolores et ducimus.", false, "Dedrick Howe", 692349L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 781, DateTimeKind.Utc).AddTicks(3724) },
                    { "3b2728ac-9267-457d-a309-43c0b7d96c47", null, "Est assumenda quisquam voluptatem consequatur cupiditate optio. Nobis occaecati eveniet possimus doloremque dolore id facilis. Earum quia placeat aut rerum architecto quasi minima est. Sed aut et quasi expedita dignissimos. Exercitationem dolorem est voluptate ut quis non soluta ullam facilis.", new DateTime(2023, 2, 5, 12, 27, 29, 779, DateTimeKind.Utc).AddTicks(8298), "Ex dolor recusandae totam.", false, "Prof. Garth Smith", 848552L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 779, DateTimeKind.Utc).AddTicks(8301) },
                    { "3e1b06e4-adb4-4d09-9658-2bc9a1eb400a", null, "Dicta quod aut aliquam totam repellendus voluptas. Non odit aut et ad iusto nostrum sed dolorem alias. Et inventore natus facere dolorum praesentium doloribus et optio. In perferendis libero eveniet qui commodi eum. Vel voluptatum recusandae pariatur optio. Vel ea est animi consectetur adipisci aut sed quod distinctio.", new DateTime(2023, 2, 5, 12, 27, 29, 784, DateTimeKind.Utc).AddTicks(387), "Aspernatur optio temporibus maxime.", false, "Jarrod West", 880498L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 784, DateTimeKind.Utc).AddTicks(387) },
                    { "69477238-2be0-49c4-9dd7-fc905c294c0b", null, "Nobis modi saepe vel vel in ex molestiae quia. Eum architecto unde veniam molestiae recusandae et. Vel nobis ratione ex sunt perspiciatis nostrum. Vel eveniet aspernatur fuga ut est perspiciatis dolorem non. Aut aut est sapiente magnam. Natus dicta optio provident rerum nulla aut quos commodi numquam.", new DateTime(2023, 2, 5, 12, 27, 29, 779, DateTimeKind.Utc).AddTicks(98), "Harum aut adipisci reprehenderit.", false, "Brock Heathcote", 177340L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 779, DateTimeKind.Utc).AddTicks(99) },
                    { "6d62e6bc-35f3-44b8-bc8f-7a2c8e04ff44", null, "Quod modi ut occaecati et dolorem iure. Autem rerum ex quasi. Magni tempora vel cumque cumque labore eius.", new DateTime(2023, 2, 5, 12, 27, 29, 782, DateTimeKind.Utc).AddTicks(378), "Et eum qui sed accusantium esse.", false, "Allen Pearlie Halvorson IV", 286053L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 782, DateTimeKind.Utc).AddTicks(380) },
                    { "7710252b-35e9-41dd-929b-bd7f7c723c86", null, "Aut ad quia maiores iure esse repellendus aut. Similique rerum ipsum qui dolorem. Ipsam dolorem cum amet qui eaque eos ducimus. Distinctio consequuntur accusamus maxime harum qui rerum. Fugit est magni provident.", new DateTime(2023, 2, 5, 12, 27, 29, 783, DateTimeKind.Utc).AddTicks(2648), "Officiis doloremque doloribus et quae ipsam voluptas voluptas.", false, "Golden Nitzsche", 523595L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 783, DateTimeKind.Utc).AddTicks(2649) },
                    { "a280baca-65d9-4f78-b2b2-23af6e182132", null, "Minus dolor et rerum est. Nulla non excepturi reprehenderit eum et sapiente ut commodi. Reprehenderit itaque in velit.", new DateTime(2023, 2, 5, 12, 27, 29, 785, DateTimeKind.Utc).AddTicks(6421), "Id nesciunt et quod.", false, "Dr. Rudolph Shayne Lockman", 779384L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 785, DateTimeKind.Utc).AddTicks(6422) },
                    { "ccc3afd7-1a40-4d23-be1f-89f6b2b52ccc", null, "Quis sed earum ut laudantium non rerum quae ea inventore. Et sed quia quas vitae quam distinctio qui eaque. Laborum doloremque culpa error aut et.", new DateTime(2023, 2, 5, 12, 27, 29, 780, DateTimeKind.Utc).AddTicks(6408), "Dolorem aut voluptas similique.", false, "Dorcas Cruickshank", 785515L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 780, DateTimeKind.Utc).AddTicks(6412) },
                    { "d627cc04-3490-48fb-bbc8-368590df9a9e", null, "Et corrupti voluptas ullam sed aut. Voluptate dignissimos consequuntur fugit et. Consequatur sint molestias quisquam quo non quam repellendus rerum. Fugit ipsa sed quasi consequatur corporis. Et placeat soluta sit officiis.", new DateTime(2023, 2, 5, 12, 27, 29, 784, DateTimeKind.Utc).AddTicks(9628), "Asperiores rerum necessitatibus omnis hic.", false, "Shayne Raynor III", 705437L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 784, DateTimeKind.Utc).AddTicks(9628) },
                    { "e964ae5e-f062-4950-8277-bf6f788d31b2", null, "Ea perferendis et ut. Sit et non nulla deleniti maiores voluptate. Aliquam delectus sit cupiditate quidem. Eaque aut nostrum et vitae.", new DateTime(2023, 2, 5, 12, 27, 29, 782, DateTimeKind.Utc).AddTicks(8406), "Velit ut in tempore ab voluptas nihil.", false, "Eino Hyatt", 105016L, 1, 0L, new DateTime(2023, 2, 5, 12, 27, 29, 782, DateTimeKind.Utc).AddTicks(8499) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "028b0e3a-ee00-429b-86b6-90ab6b5c3e43");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "319c2c3c-316d-479b-b661-5cf9baad9589");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3c9fc0ee-3ef9-44a0-8116-a10c961a4ecf");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4acd12e9-4170-4e19-90b1-eac262dddc3d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5c5d64e9-4189-4534-a3b5-314883f90adb");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "97533320-15b0-4d6b-bc3e-c3f956c2cbfe");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "a6122378-04b4-4b16-b460-4bb37c030090");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "b09f4adf-2aa8-4068-8376-5b89e912dd29");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1b6c011-ba5a-4b75-9017-2899c7360736");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "d4c4b85f-a8ad-4f53-a46f-f21ba077e942");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "230f777e-907b-419c-9a8a-4e3dce9d169b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3b2728ac-9267-457d-a309-43c0b7d96c47");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3e1b06e4-adb4-4d09-9658-2bc9a1eb400a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "69477238-2be0-49c4-9dd7-fc905c294c0b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6d62e6bc-35f3-44b8-bc8f-7a2c8e04ff44");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7710252b-35e9-41dd-929b-bd7f7c723c86");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "a280baca-65d9-4f78-b2b2-23af6e182132");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "ccc3afd7-1a40-4d23-be1f-89f6b2b52ccc");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "d627cc04-3490-48fb-bbc8-368590df9a9e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "e964ae5e-f062-4950-8277-bf6f788d31b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b600478d-f98b-4a27-aa95-14563920d28f",
                column: "ConcurrencyStamp",
                value: "eedb2042-cb09-42f4-829a-3a40dd5f7968");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                column: "ConcurrencyStamp",
                value: "1224b026-d3a9-4b7f-81ba-0691f30b5af9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                column: "ConcurrencyStamp",
                value: "89483d11-7e8f-4a0f-8fcd-a6d11c6605d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f056af36-b088-4383-be8b-0ba812f0cb7b", "e906d2a8-b70c-4900-a048-49bcb477373e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fa9827-0f5f-41db-a825-64d68d242d7e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac990f26-b322-4520-bea0-852c0d1dda1d", "d72a724e-90c4-4093-82ca-46c1b6807b83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df31566d-5ccb-45dc-b1be-864d72133ca4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a8727a0-0ece-4d74-9f73-7ea1f4195f51", "6c70c20e-7024-461f-b178-d9f8cab63b96" });

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
        }
    }
}
