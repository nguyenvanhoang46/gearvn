﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Context;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "c6e33434-cdc4-4031-98ad-473ce68b0b79",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(5909),
                            IsDeleted = false,
                            Name = "Buford Rippin",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(5912)
                        },
                        new
                        {
                            Id = "046249b3-7e4d-4a05-ad3a-efe1fa54f3b6",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(7136),
                            IsDeleted = false,
                            Name = "Faustino Goldner III",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(7136)
                        },
                        new
                        {
                            Id = "7ac24e7e-703e-4616-9a7b-a071d03a15bd",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(8161),
                            IsDeleted = false,
                            Name = "Julio Donnelly",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(8161)
                        },
                        new
                        {
                            Id = "2be6f46b-2f6c-494e-9734-1f1f0e49ee34",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(9173),
                            IsDeleted = false,
                            Name = "Chelsie King",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 29, DateTimeKind.Utc).AddTicks(9173)
                        },
                        new
                        {
                            Id = "1f7f2d3e-dfbc-4669-8d0f-0f9f6a8c6919",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(96),
                            IsDeleted = false,
                            Name = "Octavia McClure",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(96)
                        },
                        new
                        {
                            Id = "2bc7858f-d35a-4da7-be79-0e77912f7194",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1013),
                            IsDeleted = false,
                            Name = "Zena Hoppe",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1013)
                        },
                        new
                        {
                            Id = "386d32ae-3c53-4db1-9452-a95e4e1e4bc6",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1958),
                            IsDeleted = false,
                            Name = "Marcelo Labadie",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(1958)
                        },
                        new
                        {
                            Id = "250d1a43-afb4-4b09-94fa-776e1bb531eb",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(2877),
                            IsDeleted = false,
                            Name = "Ida Wuckert",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(2877)
                        },
                        new
                        {
                            Id = "353a134a-076b-4df8-8ab5-93ec30cf6608",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(3743),
                            IsDeleted = false,
                            Name = "Reyes Hickle",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(3743)
                        },
                        new
                        {
                            Id = "37b579a6-fbdf-4f85-85a1-85a90fa7f020",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(4813),
                            IsDeleted = false,
                            Name = "Deanna Bartoletti",
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(4814)
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

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
                            Id = "0aff9e69-fd7c-4f65-9fb5-cf02e0ace38a",
                            Content = "Id iste praesentium nesciunt sunt voluptatem. Et explicabo cum doloribus aut consequatur vitae voluptatem corporis. Omnis est eos corrupti porro veritatis. Est et officiis rerum. Id non qui enim dolorum qui porro et. Alias est molestias facilis voluptatibus alias nemo qui illo tempora.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(5886),
                            Description = "Rem reiciendis quo ex adipisci itaque.",
                            IsDeleted = false,
                            Name = "Mrs. Gene Magdalen Witting",
                            Price = 110137L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 30, DateTimeKind.Utc).AddTicks(5886)
                        },
                        new
                        {
                            Id = "e70805b1-1a8d-42cd-ada2-706fdcea6fc1",
                            Content = "Est ut consequuntur temporibus vero asperiores perferendis harum. Non reiciendis atque quo expedita ipsa. Sed maiores aut est sint est nihil veritatis nesciunt.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(622),
                            Description = "Ipsa vel cumque alias est exercitationem.",
                            IsDeleted = false,
                            Name = "Juliana Anderson",
                            Price = 516561L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(623)
                        },
                        new
                        {
                            Id = "8922a27b-5d4c-41b6-a9f3-92307b4e5956",
                            Content = "Eum ratione dolores vero officia dolorem iure. Et ea facilis et eligendi magni non non aut et. Qui quo ipsum fugiat illum beatae quaerat rerum vero quis. Reprehenderit consequuntur sed vel sunt voluptatibus quisquam. Delectus rem numquam corporis laudantium voluptatem velit delectus omnis. Veniam ut sint esse mollitia et aliquam quia.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(3350),
                            Description = "Eum porro voluptatem facere fugiat ut nemo maiores.",
                            IsDeleted = false,
                            Name = "Miss Katlyn Tyrell Renner",
                            Price = 538866L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(3351)
                        },
                        new
                        {
                            Id = "c5f02cba-30be-4bc9-af41-e610e47d22f5",
                            Content = "Veniam et autem qui corrupti sed. Ullam est esse sunt nam. Tenetur qui magni soluta beatae perferendis libero quia ad. Exercitationem rerum quae quibusdam architecto id eos dicta et. Necessitatibus minima ea iste rerum eum omnis vitae quae ut. Et mollitia quas earum non molestias non non minima.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(8570),
                            Description = "Dolores reprehenderit saepe in quia ipsum voluptas eum doloribus.",
                            IsDeleted = false,
                            Name = "Miss Frank Douglas",
                            Price = 142752L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 31, DateTimeKind.Utc).AddTicks(8571)
                        },
                        new
                        {
                            Id = "9c1043b8-9702-40e9-a813-c7730d4dd042",
                            Content = "Vel itaque quia velit minima. Eaque sunt ducimus rerum. Quas eveniet sit at ipsum reprehenderit corporis expedita et veniam.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(3488),
                            Description = "Nisi quia dignissimos vel ut est consectetur quia omnis et.",
                            IsDeleted = false,
                            Name = "Elfrieda Schulist",
                            Price = 761109L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(3490)
                        },
                        new
                        {
                            Id = "0c5ecfc9-2e67-4709-9858-572b4007d07e",
                            Content = "Quidem suscipit totam dicta modi neque nobis laudantium voluptatum harum. Repellendus inventore ut quidem veritatis sed dolorem placeat vitae. Voluptas consequuntur et dolores. Non sit eos numquam tempore reiciendis ut rerum molestias voluptatem. Ut laudantium quibusdam ipsam. Quia soluta autem perspiciatis eius assumenda illo consectetur provident recusandae.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(6231),
                            Description = "Ea omnis libero laboriosam quae itaque repellendus explicabo.",
                            IsDeleted = false,
                            Name = "Ivy Graham DDS",
                            Price = 174264L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 32, DateTimeKind.Utc).AddTicks(6232)
                        },
                        new
                        {
                            Id = "c0040539-3dcc-49ed-86c5-e0006f043b1c",
                            Content = "Fuga nostrum alias rerum iste nemo consequatur. Eum reprehenderit aut reprehenderit et quam aliquam soluta. Quod velit officiis deserunt saepe molestias optio. Vero tempore nihil quo nostrum aut.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(390),
                            Description = "Nisi in necessitatibus labore.",
                            IsDeleted = false,
                            Name = "Benny Wuckert",
                            Price = 298439L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(391)
                        },
                        new
                        {
                            Id = "0250efd3-de7f-4253-99aa-240ffd8bb4ae",
                            Content = "Accusamus omnis dolore et. Ipsum quia aspernatur cum numquam voluptas porro. Aspernatur non repudiandae et et fugiat. Voluptatem quos labore vel ea aliquid deserunt accusantium. Eveniet aperiam nihil provident earum alias et molestiae. Quos et voluptatem natus in est quod.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(3236),
                            Description = "Aspernatur enim vel minima dolorem ex deleniti iure modi.",
                            IsDeleted = false,
                            Name = "Prof. Ernestina Muller PhD",
                            Price = 430783L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(3237)
                        },
                        new
                        {
                            Id = "40a1bd7d-f011-455c-b8d4-2b5a3c7169d9",
                            Content = "Aut quia voluptatem sunt rerum provident eum est ullam quod. Nihil aut doloribus sit aut quo nisi eligendi ducimus. Voluptatem quod qui nostrum et id non sunt. Sint non quam dolorem laborum libero.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(7081),
                            Description = "Accusamus vitae sed et quo libero.",
                            IsDeleted = false,
                            Name = "Bryce Bins",
                            Price = 523218L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 33, DateTimeKind.Utc).AddTicks(7084)
                        },
                        new
                        {
                            Id = "56639b8a-46f6-45f9-8e50-3fb2ae3f7290",
                            Content = "Assumenda in neque nostrum. Sunt modi dolorem aut et. Omnis vel veritatis reiciendis consequatur qui. Ipsa veniam in aut. Non omnis cumque quaerat dolores aut quos aut autem quidem. Totam repudiandae quidem ut et et excepturi vero ducimus.",
                            CreatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 34, DateTimeKind.Utc).AddTicks(251),
                            Description = "Ut dolore aliquam velit rem est ea.",
                            IsDeleted = false,
                            Name = "Jerald Ritchie",
                            Price = 776616L,
                            Quantity = 1,
                            SalePrice = 0L,
                            UpdatedAt = new DateTime(2022, 12, 26, 3, 48, 17, 34, DateTimeKind.Utc).AddTicks(252)
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
                            ConcurrencyStamp = "9b3dc9c7-9274-4bd3-9fd2-fb587cde0435",
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
                            SecurityStamp = "4f9b8c16-0019-42d2-942f-94460e0b151b",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "75fa9827-0f5f-41db-a825-64d68d242d7e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa9eb516-cf2b-4ee0-a353-fb20272973f3",
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
                            SecurityStamp = "141ae25e-f808-47c0-839c-d1ec2f8a18af",
                            TwoFactorEnabled = false,
                            UserName = "User"
                        },
                        new
                        {
                            Id = "df31566d-5ccb-45dc-b1be-864d72133ca4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ecfb82d-6ec1-45dd-953a-ef4b93046d15",
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
                            SecurityStamp = "9833f343-a286-49d8-afc4-15c956e75133",
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
                            ConcurrencyStamp = "1d37f90a-fcbf-4e1f-b13a-216e962e17c3",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
                            ConcurrencyStamp = "efe42aad-1448-4740-bae2-146dbd3c4e1a",
                            Name = "User",
                            NormalizedName = "USER",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "b600478d-f98b-4a27-aa95-14563920d28f",
                            ConcurrencyStamp = "48231ff4-2bb9-4ce3-ad5e-0808cb3d3a42",
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
