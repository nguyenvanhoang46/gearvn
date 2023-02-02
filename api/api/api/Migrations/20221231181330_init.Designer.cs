﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Context;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221231181330_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("api.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = "e0594e9f-f51f-4213-af36-b6cf5a3334e0",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 828, DateTimeKind.Utc).AddTicks(9388),
                            IsDeleted = false,
                            Name = "Felipe Willms",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 828, DateTimeKind.Utc).AddTicks(9390)
                        },
                        new
                        {
                            Id = "927a829d-a855-45cc-b5ef-020524bfbe98",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(452),
                            IsDeleted = false,
                            Name = "Mr. Julio Pacocha",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(452)
                        },
                        new
                        {
                            Id = "f19fb9ed-6ad6-42ba-a5b5-07884422223d",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(3141),
                            IsDeleted = false,
                            Name = "Miss Uriel Wendy Cassin",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(3142)
                        },
                        new
                        {
                            Id = "fc426f7c-5f16-4c9a-b96c-0d4c9006fd8d",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(5694),
                            IsDeleted = false,
                            Name = "Nicolette Bogisich",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(5695)
                        },
                        new
                        {
                            Id = "e904c016-2a4c-46d6-a2ea-69b345f1fd00",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(7118),
                            IsDeleted = false,
                            Name = "Rudy Hyatt",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(7119)
                        },
                        new
                        {
                            Id = "ca722bb2-4ae8-45ea-b411-b5b51ab97cd5",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(8476),
                            IsDeleted = false,
                            Name = "Andreane Hodkiewicz",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(8477)
                        },
                        new
                        {
                            Id = "25a77564-0c0e-46c3-9b17-ec4c295e0911",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(9527),
                            IsDeleted = false,
                            Name = "Paxton Cartwright",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 829, DateTimeKind.Utc).AddTicks(9527)
                        },
                        new
                        {
                            Id = "4c9d3b90-dfcd-4f53-9f7a-41d8e970ca88",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(432),
                            IsDeleted = false,
                            Name = "Jammie Rodolfo Boyle V",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(433)
                        },
                        new
                        {
                            Id = "ae54eea6-1e52-487b-a3c7-203f7cf46dd4",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(2064),
                            IsDeleted = false,
                            Name = "Gage Leuschke",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(2065)
                        },
                        new
                        {
                            Id = "2c3bb582-a3eb-4d8d-ab97-f1be68b20785",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(3037),
                            IsDeleted = false,
                            Name = "Danial Marquardt",
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(3037)
                        });
                });

            modelBuilder.Entity("api.Models.Morph.Image", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OrderCompletionType")
                        .HasColumnType("int");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("api.Models.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProductId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("api.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("SalePrice")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = "cf60152a-aac5-4632-b964-029d87bd929a",
                            Content = "Aspernatur vero repellat quis reprehenderit sed id officia quod. Molestiae temporibus ex non culpa id. Tempore corrupti enim eos atque velit aliquam dolorum.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(4389),
                            Description = "Occaecati vitae nesciunt enim voluptatum.",
                            IsDeleted = false,
                            Name = "Herbert Ritchie",
                            Price = 708097L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(4390)
                        },
                        new
                        {
                            Id = "04e07f8a-c08b-4087-b886-d84f47d1bb59",
                            Content = "Amet numquam et quos maiores suscipit neque quae consequuntur eligendi. Dolorem unde non in assumenda corrupti ut doloribus qui ex. Placeat et veritatis facilis tempora aut. Doloremque est hic dolor qui vel nesciunt a quod. Voluptas eligendi hic quia reiciendis et rem eveniet molestiae odio.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(8427),
                            Description = "Suscipit hic doloremque repudiandae itaque voluptatem.",
                            IsDeleted = false,
                            Name = "Brain King",
                            Price = 376882L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 830, DateTimeKind.Utc).AddTicks(8429)
                        },
                        new
                        {
                            Id = "adb930f1-e844-4303-932c-c5c2b9b38ac4",
                            Content = "Sequi enim nihil maxime autem velit. Mollitia molestias qui quod quia reiciendis consequatur. Veniam voluptate nam reiciendis soluta enim quia natus dolorum.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(3854),
                            Description = "Eum et quas non aliquam.",
                            IsDeleted = false,
                            Name = "Lucio Jacobs",
                            Price = 111210L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(3855)
                        },
                        new
                        {
                            Id = "e8a28e99-ad41-4aa3-a154-e5e72b174a54",
                            Content = "Omnis animi eaque illum libero debitis natus. Impedit voluptas necessitatibus quidem assumenda. Dolorum nobis fuga rerum nulla. Nulla et nihil cumque doloribus eaque. Aperiam et est aut ut.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(6411),
                            Description = "Perferendis eligendi asperiores autem non reiciendis aperiam.",
                            IsDeleted = false,
                            Name = "Dorian Zieme",
                            Price = 836000L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 831, DateTimeKind.Utc).AddTicks(6411)
                        },
                        new
                        {
                            Id = "432de664-819d-4272-b129-9cfdc98cd816",
                            Content = "Voluptatum distinctio doloribus consequatur ea esse. Necessitatibus sed at voluptates id. Fugiat veniam et voluptates fugit perspiciatis omnis deleniti. Sed dolore odio eveniet.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(156),
                            Description = "Occaecati magni et reiciendis aut et quis esse et nisi.",
                            IsDeleted = false,
                            Name = "Prof. Izabella Jeanie Terry",
                            Price = 206418L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(157)
                        },
                        new
                        {
                            Id = "9f44c4db-7349-4c1e-90a7-6a521c5e3420",
                            Content = "Itaque laudantium et assumenda repudiandae. Qui exercitationem magni quis. At dolores est sit omnis vero autem occaecati vero.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(4407),
                            Description = "Ratione vel iusto qui minus eveniet.",
                            IsDeleted = false,
                            Name = "Nella Murphy",
                            Price = 638306L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(4408)
                        },
                        new
                        {
                            Id = "f4947ecc-c6b9-44b2-bd4f-39f341f3a196",
                            Content = "Earum repellat voluptatem quia inventore. Doloremque incidunt hic suscipit est quo iure. Praesentium quisquam sed ut. Omnis sed distinctio voluptatem vel vel in sed eius. In dolor vero et quisquam est delectus laboriosam libero aut. Impedit veniam excepturi sit excepturi voluptas et qui tenetur pariatur.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(8424),
                            Description = "Dolorem eveniet accusantium soluta enim dolor voluptatem excepturi.",
                            IsDeleted = false,
                            Name = "Gonzalo Borer",
                            Price = 628161L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 832, DateTimeKind.Utc).AddTicks(8425)
                        },
                        new
                        {
                            Id = "4010a15c-4e8d-4712-9c52-b40abb6f2b50",
                            Content = "Doloremque et doloremque labore est repellendus veniam ipsam. Fugit quam deleniti delectus odio eos. Vel sed quam labore consequatur deleniti voluptatem. Dolorem dolores itaque qui nam. Sit maxime ut reiciendis aliquid.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 833, DateTimeKind.Utc).AddTicks(4930),
                            Description = "Repudiandae aliquam sit repellat.",
                            IsDeleted = false,
                            Name = "Prof. Kobe Kaitlyn Padberg",
                            Price = 936967L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 833, DateTimeKind.Utc).AddTicks(4931)
                        },
                        new
                        {
                            Id = "6cc1f7ac-99f6-4afd-9bb5-85fcdec9e930",
                            Content = "Explicabo reprehenderit vel non quibusdam explicabo. Sed voluptates est nisi aut et fugit hic. At modi esse et consequuntur asperiores libero.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(1197),
                            Description = "Odio repellendus recusandae rerum est.",
                            IsDeleted = false,
                            Name = "Prof. Rubye Johan Orn DVM",
                            Price = 335915L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(1197)
                        },
                        new
                        {
                            Id = "68e72d95-e3d7-4ca4-9f83-428d24d951d5",
                            Content = "Alias quae voluptatem sit iusto ut. Laborum temporibus amet aut error saepe sed veniam et accusantium. Dolore consequatur asperiores expedita suscipit natus consequatur error et. Itaque odit nihil saepe voluptatem in. Dicta unde velit beatae ut ducimus porro necessitatibus maiores. Vel sunt quidem est et odio sed.",
                            CreatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(4450),
                            Description = "Dolores eum quam et velit inventore facilis.",
                            IsDeleted = false,
                            Name = "Dr. Beryl Sam D'Amore",
                            Price = 854246L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 31, 18, 13, 29, 834, DateTimeKind.Utc).AddTicks(4451)
                        });
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a08e5ad9-28e0-4f60-bb8c-c8002b0183db",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "156d842f-00d0-40ed-a19c-ae460d0559b5",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "75fa9827-0f5f-41db-a825-64d68d242d7e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd963ab8-f3fe-46eb-8a91-be552afde1cb",
                            Email = "user@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMAIL.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "f7844d72-cd13-4beb-bc57-9920c67b8333",
                            TwoFactorEnabled = false,
                            UserName = "User"
                        },
                        new
                        {
                            Id = "df31566d-5ccb-45dc-b1be-864d72133ca4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d5437d1-c063-4339-b0ab-e23078333747",
                            Email = "guest@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "Guest",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "848077e4-b9d3-4440-b976-6f4e904bc6b6",
                            TwoFactorEnabled = false,
                            UserName = "Guest"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
                            RoleId = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c"
                        },
                        new
                        {
                            UserId = "75fa9827-0f5f-41db-a825-64d68d242d7e",
                            RoleId = "dddd1a59-3b57-45f6-96b5-91b3e269e87c"
                        },
                        new
                        {
                            UserId = "df31566d-5ccb-45dc-b1be-864d72133ca4",
                            RoleId = "b600478d-f98b-4a27-aa95-14563920d28f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("api.Models.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("Role");

                    b.HasData(
                        new
                        {
                            Id = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                            ConcurrencyStamp = "421a1269-d467-4a7a-8b5d-e05c578c46d5",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                            ConcurrencyStamp = "e71f235d-9ebf-49e9-aa40-cdf596516c3a",
                            Name = "User",
                            NormalizedName = "USER",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "b600478d-f98b-4a27-aa95-14563920d28f",
                            ConcurrencyStamp = "b857d74d-b9a3-43a7-a80b-492e6d203d6c",
                            Name = "Guest",
                            NormalizedName = "GUEST",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("api.Models.Morph.Image", b =>
                {
                    b.HasOne("api.Models.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.HasOne("api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("api.Models.OrderDetail", b =>
                {
                    b.HasOne("api.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("api.Models.Product", b =>
                {
                    b.HasOne("api.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("api.Models.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
