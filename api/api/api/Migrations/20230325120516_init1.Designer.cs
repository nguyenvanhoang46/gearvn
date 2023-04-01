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
    [Migration("20230325120516_init1")]
    partial class init1
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
                            Id = "c2ef41ed-f0d0-4c0a-acb1-39ea65bcea3f",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(7780),
                            IsDeleted = false,
                            Name = "Lacy Witting",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(7785)
                        },
                        new
                        {
                            Id = "112148cc-9f86-46a7-84e2-194a48250606",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(8911),
                            IsDeleted = false,
                            Name = "Raquel Crist",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(8911)
                        },
                        new
                        {
                            Id = "7c5b129b-0eb6-498a-8e22-e2eb8951a21a",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(9794),
                            IsDeleted = false,
                            Name = "Gordon Feeney V",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 613, DateTimeKind.Utc).AddTicks(9795)
                        },
                        new
                        {
                            Id = "a6ab2db2-5d6a-4b0a-bdad-596a0239918b",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(673),
                            IsDeleted = false,
                            Name = "Nola Turner",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(674)
                        },
                        new
                        {
                            Id = "068fe362-9be4-4ce2-84dc-95912d0d8fdf",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(1687),
                            IsDeleted = false,
                            Name = "Juvenal Reinger",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(1687)
                        },
                        new
                        {
                            Id = "022f9f9b-6bb0-4831-a8c9-af4bded1052d",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(2583),
                            IsDeleted = false,
                            Name = "Mr. Monica Helmer Kuvalis",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(2583)
                        },
                        new
                        {
                            Id = "021f916b-ea77-4231-af55-7c06c03216cf",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(4158),
                            IsDeleted = false,
                            Name = "Miss Donnie Collier",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(4158)
                        },
                        new
                        {
                            Id = "f0176c71-a172-4f69-8b3c-11844897561c",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(5140),
                            IsDeleted = false,
                            Name = "Alfred Hintz",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(5141)
                        },
                        new
                        {
                            Id = "f34f040f-4218-4984-8c1e-b38739622e51",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(6018),
                            IsDeleted = false,
                            Name = "Dr. Zackery Aliza Hegmann MD",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(6018)
                        },
                        new
                        {
                            Id = "de466ad2-9499-41ca-b910-eeb105832d75",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(7674),
                            IsDeleted = false,
                            Name = "Mr. Kip Gerlach DDS",
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(7675)
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

                    b.Property<string>("City")
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
                            Id = "a2c5eaf2-c8be-48e5-950e-5f04964f4c51",
                            Content = "Alias atque expedita soluta. Ipsam facilis sed et qui suscipit dolorem aut et. Animi quia et dolorem eum eveniet dolorum non.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(8593),
                            Description = "Doloribus cupiditate facilis soluta labore odit voluptates ut.",
                            IsDeleted = false,
                            Name = "Eusebio Oberbrunner II",
                            Price = 324744L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 614, DateTimeKind.Utc).AddTicks(8593)
                        },
                        new
                        {
                            Id = "22be2903-4d8a-4a98-a96f-8076ccc2c3a0",
                            Content = "Vitae accusamus deserunt pariatur quibusdam quia aut delectus. Maxime ut dolores recusandae ea. Incidunt ipsam nihil quae illo.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(1755),
                            Description = "Nam eum sint odio dolorum quia ea consequatur.",
                            IsDeleted = false,
                            Name = "Prof. Paul Jody Legros I",
                            Price = 207439L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(1756)
                        },
                        new
                        {
                            Id = "364801c7-0094-496f-a50a-7b8c3097a466",
                            Content = "Est rem incidunt libero voluptatem voluptas qui et. Commodi et dolore consectetur quam id tenetur dolorum dicta. Quia laboriosam quisquam aut aut harum corporis ipsum.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(5213),
                            Description = "Laboriosam iusto recusandae voluptates.",
                            IsDeleted = false,
                            Name = "Miss Jesse Garnet Bashirian",
                            Price = 435045L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(5218)
                        },
                        new
                        {
                            Id = "26b4f261-63cc-4fc4-ab1c-c00b5300eb60",
                            Content = "Et molestias sunt sed animi fugiat optio accusamus. Et alias aut praesentium aperiam. Eveniet aut voluptatem ipsa. Eveniet optio eos molestiae quisquam. Earum et quia esse perferendis minus quaerat in incidunt. Dolorem et voluptas et aperiam.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(8833),
                            Description = "Nihil ea ut reprehenderit perspiciatis.",
                            IsDeleted = false,
                            Name = "Chester Hammes",
                            Price = 744210L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 615, DateTimeKind.Utc).AddTicks(8837)
                        },
                        new
                        {
                            Id = "0868199b-d1ec-4dfe-bdcd-9e450fbea376",
                            Content = "Illo libero repudiandae neque sed totam. Possimus accusantium at dolorem. Ipsum quas ea maiores eum id alias quod. Est molestias perspiciatis nulla eius nostrum qui. Error distinctio est accusantium et. Praesentium sunt libero sed pariatur ab voluptas expedita porro explicabo.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(2799),
                            Description = "Aut quibusdam qui non hic culpa in optio.",
                            IsDeleted = false,
                            Name = "Lemuel Gibson",
                            Price = 991867L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(2803)
                        },
                        new
                        {
                            Id = "7b83b6e8-462c-4f74-bb66-67d6d2864d3f",
                            Content = "Mollitia quia dignissimos aut nostrum ducimus ullam sunt dolorum. Et nisi laborum repudiandae ullam voluptas aut. Voluptatem voluptate sequi eum.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(6830),
                            Description = "Et dolorum sunt voluptatem.",
                            IsDeleted = false,
                            Name = "Miss Dashawn Coby Kris",
                            Price = 110972L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 616, DateTimeKind.Utc).AddTicks(6833)
                        },
                        new
                        {
                            Id = "b4707bd1-2047-43f3-a08a-a607e7b6fb01",
                            Content = "Voluptas excepturi nam accusantium eveniet libero. Consequatur laborum tempore occaecati repellat maiores qui quos excepturi magnam. Sapiente explicabo aliquam asperiores est illum voluptate fuga.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(714),
                            Description = "Et mollitia eius sint et dolor voluptatibus ut.",
                            IsDeleted = false,
                            Name = "Ms. Eliza Marks",
                            Price = 581715L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(716)
                        },
                        new
                        {
                            Id = "e972b27f-b387-4802-893d-250fdc401d67",
                            Content = "Consequatur voluptate quos odio. Qui tempore ipsam minima quia expedita. Explicabo perspiciatis porro odio voluptates ipsa dignissimos accusantium. Itaque a qui sunt quod. Et et quaerat quis hic non nisi dolores consequuntur.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(3961),
                            Description = "Iure excepturi ut sunt accusantium aut sequi alias.",
                            IsDeleted = false,
                            Name = "Candida Feest",
                            Price = 716698L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(3967)
                        },
                        new
                        {
                            Id = "492ae5ab-30c3-42f4-af19-346ba920366c",
                            Content = "Qui et nostrum alias velit et sit numquam eos. Ullam deleniti qui et repellat id ut consequuntur reprehenderit sequi. Explicabo quisquam velit quibusdam est.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(7921),
                            Description = "Soluta ut natus nulla neque.",
                            IsDeleted = false,
                            Name = "Ottis Veum",
                            Price = 411331L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 617, DateTimeKind.Utc).AddTicks(7924)
                        },
                        new
                        {
                            Id = "c61e019f-78cd-4f13-8706-80c9f60ae148",
                            Content = "Ipsa ipsa consequuntur illum qui in. Molestiae laboriosam commodi sunt nihil maxime non. Cupiditate dolore vel doloremque culpa qui repudiandae sed necessitatibus. Dolor repudiandae omnis odit illo et et. Delectus repellat omnis et et. Vero quia dignissimos provident quae non.",
                            CreatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 618, DateTimeKind.Utc).AddTicks(725),
                            Description = "Cumque corrupti qui voluptatem rerum saepe consequatur sit quia.",
                            IsDeleted = false,
                            Name = "Kianna Batz",
                            Price = 113076L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2023, 3, 25, 12, 5, 16, 618, DateTimeKind.Utc).AddTicks(726)
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

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
                            ConcurrencyStamp = "4ed75fd8-b93c-44e2-9073-0cae01936c73",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "186423ff-5998-4d13-a442-f386fca41ba6",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "75fa9827-0f5f-41db-a825-64d68d242d7e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b76fdbcc-d2cd-4bb8-b346-eb2e5202c22d",
                            Email = "user@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            IsDeleted = false,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMAIL.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "8d5a991c-556c-4839-8650-4ed28075ca6a",
                            TwoFactorEnabled = false,
                            UserName = "User"
                        },
                        new
                        {
                            Id = "df31566d-5ccb-45dc-b1be-864d72133ca4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a3461dfa-4d12-40a2-a84d-889f8b0e816d",
                            Email = "guest@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            IsDeleted = false,
                            LastName = "Guest",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST",
                            PasswordHash = "AAuIVXm1hor21nLBhSwPe59KTGKy2+Yvw6rJSey4WiFHXM6pa0VvOV7RtQ5qG59sRQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "4a50da4a-24a9-4410-b7be-c73e0842adee",
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("Role");

                    b.HasData(
                        new
                        {
                            Id = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
                            ConcurrencyStamp = "a8179dc6-5f5a-4e36-9e08-429e80a0cf61",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                            ConcurrencyStamp = "ee8ccc89-371c-487d-9600-d36ee576efe6",
                            Name = "User",
                            NormalizedName = "USER",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = "b600478d-f98b-4a27-aa95-14563920d28f",
                            ConcurrencyStamp = "5206410b-a4e1-4d89-a4e0-5efce5888d71",
                            Name = "Guest",
                            NormalizedName = "GUEST",
                            IsDeleted = false
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