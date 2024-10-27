﻿// <auto-generated />
using System;
using Ecommerce1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241026231348_UpdateAppUserSchema")]
    partial class UpdateAppUserSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce1.Data.Cart_item", b =>
                {
                    b.Property<int>("Id_cart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cart"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Shop_Session")
                        .HasColumnType("int");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_cart");

                    b.HasIndex("Id_Shop_Session");

                    b.HasIndex("Id_product");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            Id_cart = 1,
                            Created = "2023-10-15",
                            Id_Shop_Session = 1,
                            Id_product = 1,
                            Modified = "2023-10-15",
                            Quantity = 2
                        },
                        new
                        {
                            Id_cart = 2,
                            Created = "2023-10-15",
                            Id_Shop_Session = 1,
                            Id_product = 2,
                            Modified = "2023-10-15",
                            Quantity = 1
                        },
                        new
                        {
                            Id_cart = 3,
                            Created = "2023-10-16",
                            Id_Shop_Session = 2,
                            Id_product = 5,
                            Modified = "2023-10-16",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Discount", b =>
                {
                    b.Property<int>("Id_discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_discount"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_discount");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id_discount = 1,
                            Created = "2023-10-01 10:30:00",
                            Description = "10% off all fruits",
                            Modified = "2023-10-01 10:30:00",
                            Name = "Fruit Discount",
                            Percent = 10m
                        },
                        new
                        {
                            Id_discount = 2,
                            Created = "2023-10-02 10:30:00",
                            Description = "15% off on dairy products",
                            Modified = "2023-10-02 10:30:00",
                            Name = "Dairy Discount",
                            Percent = 15m
                        },
                        new
                        {
                            Id_discount = 3,
                            Created = "2023-10-03 10:30:00",
                            Description = "Buy 2 Get 1 Free on bakery items",
                            Modified = "2023-10-03 10:30:00",
                            Name = "Bakery Discount",
                            Percent = 5m
                        },
                        new
                        {
                            Id_discount = 4,
                            Created = "2023-10-03 10:30:00",
                            Description = "Buy 3 Get 1 Free on meat products",
                            Modified = "2023-10-03 10:30:00",
                            Name = "Meat Discount",
                            Percent = 10m
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Order", b =>
                {
                    b.Property<int>("Id_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Order"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_product");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id_Order = 1,
                            Created = "2023-10-17",
                            Id_product = 1,
                            Modified = "2023-10-17"
                        },
                        new
                        {
                            Id_Order = 2,
                            Created = "2023-10-18",
                            Id_product = 2,
                            Modified = "2023-10-18"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Order_Details", b =>
                {
                    b.Property<int>("Id_details")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_details"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_AppUser")
                        .HasColumnType("int");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_details");

                    b.HasIndex("Id_AppUser");

                    b.HasIndex("Id_Order");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id_details = 1,
                            Created = "2023-10-19",
                            Id_AppUser = 1,
                            Id_Order = 1,
                            Modified = "2023-10-19"
                        },
                        new
                        {
                            Id_details = 2,
                            Created = "2023-10-19",
                            Id_AppUser = 2,
                            Id_Order = 1,
                            Modified = "2023-10-19"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Payment", b =>
                {
                    b.Property<int>("Id_payments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_payments"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_payments");

                    b.HasIndex("Id_Order");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id_payments = 1,
                            Amount = 5.00m,
                            Created = "2023-10-20",
                            Id_Order = 1,
                            Modified = "2023-10-20",
                            Provider = "Paypal",
                            Status = "Completed"
                        },
                        new
                        {
                            Id_payments = 2,
                            Amount = 8.50m,
                            Created = "2023-10-21",
                            Id_Order = 2,
                            Modified = "2023-10-21",
                            Provider = "Credit Card",
                            Status = "Pending"
                        },
                        new
                        {
                            Id_payments = 3,
                            Amount = 8.50m,
                            Created = "2023-10-23",
                            Id_Order = 2,
                            Modified = "2023-10-24",
                            Provider = "Bank Transfer",
                            Status = "Completed"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Product", b =>
                {
                    b.Property<int>("Id_product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_product"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_discount")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_product");

                    b.HasIndex("Id_discount");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id_product = 1,
                            Category = "Fruits",
                            Created = "2023-10-01 10:30:00",
                            Description = "Fresh Red Apple",
                            Id_discount = 1,
                            Modified = "2023-10-05 14:20:00",
                            Name = "Apple",
                            Price = 0.99m,
                            SKU = "FRU-APL-001"
                        },
                        new
                        {
                            Id_product = 2,
                            Category = "Fruits",
                            Created = "2023-10-02 09:15:00",
                            Description = "Exotic Bananas",
                            Id_discount = 1,
                            Modified = "2023-10-06 12:40:00",
                            Name = "Banana",
                            Price = 1.20m,
                            SKU = "FRU-BAN-002"
                        },
                        new
                        {
                            Id_product = 3,
                            Category = "Vegetables",
                            Created = "2023-10-03 11:30:00",
                            Description = "Fresh Carrots",
                            Modified = "2023-10-07 09:00:00",
                            Name = "Carrot",
                            Price = 0.50m,
                            SKU = "VEG-CAR-003"
                        },
                        new
                        {
                            Id_product = 4,
                            Category = "Vegetables",
                            Created = "2023-10-04 14:45:00",
                            Description = "Fresh Lemon",
                            Modified = "2023-10-08 16:20:00",
                            Name = "Lemon",
                            Price = 2.50m,
                            SKU = "VEG-TOM-004"
                        },
                        new
                        {
                            Id_product = 5,
                            Category = "Dairy",
                            Created = "2023-10-05 08:30:00",
                            Description = "Whole Milk, 1 Gallon",
                            Id_discount = 2,
                            Modified = "2023-10-09 15:35:00",
                            Name = "Milk",
                            Price = 3.99m,
                            SKU = "DAR-MIL-005"
                        },
                        new
                        {
                            Id_product = 6,
                            Category = "Dairy",
                            Created = "2023-10-06 12:00:00",
                            Description = "Dozen Organic Eggs",
                            Id_discount = 2,
                            Modified = "2023-10-10 18:00:00",
                            Name = "Eggs",
                            Price = 2.99m,
                            SKU = "DAR-EGG-006"
                        },
                        new
                        {
                            Id_product = 7,
                            Category = "Bakery",
                            Created = "2023-10-07 07:50:00",
                            Description = "Whole Wheat Bread Loaf",
                            Id_discount = 3,
                            Modified = "2023-10-11 12:15:00",
                            Name = "Bread",
                            Price = 2.50m,
                            SKU = "BAK-BRD-007"
                        },
                        new
                        {
                            Id_product = 8,
                            Category = "Meat",
                            Created = "2023-10-08 09:30:00",
                            Description = "Skinless Boneless Chicken Breast, 1 lb",
                            Id_discount = 4,
                            Modified = "2023-10-12 11:45:00",
                            Name = "Chicken Breast",
                            Price = 4.99m,
                            SKU = "MEA-CHK-008"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Data.Shopping_Session", b =>
                {
                    b.Property<int>("Id_Shop_Session")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Shop_Session"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_AppUser")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Shop_Session");

                    b.HasIndex("Id_AppUser");

                    b.ToTable("ShoppingSessions");

                    b.HasData(
                        new
                        {
                            Id_Shop_Session = 1,
                            Created = "2023-10-12",
                            Id_AppUser = 1,
                            Modified = "2023-10-12",
                            Total_price = 5.00m
                        },
                        new
                        {
                            Id_Shop_Session = 2,
                            Created = "2023-10-13",
                            Id_AppUser = 2,
                            Modified = "2023-10-13",
                            Total_price = 8.50m
                        },
                        new
                        {
                            Id_Shop_Session = 3,
                            Created = "2023-10-14",
                            Id_AppUser = 3,
                            Modified = "2023-10-14",
                            Total_price = 3.75m
                        });
                });

            modelBuilder.Entity("Ecommerce1.Models.AppUsers", b =>
                {
                    b.Property<int>("Id_Appuser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Appuser"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id_Appuser");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id_Appuser = 1,
                            Created = new DateTime(2023, 10, 1, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            PasswordHash = "gM}56fjg",
                            PhoneNumberConfirmed = false
                        },
                        new
                        {
                            Id_Appuser = 2,
                            Created = new DateTime(2023, 10, 2, 11, 25, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@protonmail.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            LastName = "Smith",
                            PasswordHash = ">3LUmc=RvyGRHW%g/-~z",
                            PhoneNumberConfirmed = false
                        },
                        new
                        {
                            Id_Appuser = 3,
                            Created = new DateTime(2023, 10, 3, 14, 45, 0, 0, DateTimeKind.Unspecified),
                            Email = "mark.williams@domain.com",
                            EmailConfirmed = false,
                            FirstName = "Mark",
                            LastName = "Williams",
                            PasswordHash = "x*D5-UV/89`&^_q,v-H7",
                            PhoneNumberConfirmed = false
                        },
                        new
                        {
                            Id_Appuser = 4,
                            Created = new DateTime(2023, 10, 4, 9, 50, 0, 0, DateTimeKind.Unspecified),
                            Email = "emma.jones@outlook.com",
                            EmailConfirmed = false,
                            FirstName = "Emma",
                            LastName = "Jones",
                            PasswordHash = "fCxwnchJs1w|-S}YA>-F",
                            PhoneNumberConfirmed = false
                        },
                        new
                        {
                            Id_Appuser = 5,
                            Created = new DateTime(2023, 10, 5, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "robert.brown@yahoo.com",
                            EmailConfirmed = false,
                            FirstName = "Robert",
                            LastName = "Brown",
                            PasswordHash = "(y.<vQ3[8w*]KYgMs3ab",
                            PhoneNumberConfirmed = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Ecommerce1.Data.Cart_item", b =>
                {
                    b.HasOne("Ecommerce1.Data.Shopping_Session", "Shopping_Session")
                        .WithMany()
                        .HasForeignKey("Id_Shop_Session")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce1.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Id_product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Shopping_Session");
                });

            modelBuilder.Entity("Ecommerce1.Data.Order", b =>
                {
                    b.HasOne("Ecommerce1.Data.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("Id_product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce1.Data.Order_Details", b =>
                {
                    b.HasOne("Ecommerce1.Models.AppUsers", "AppUsers")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Id_AppUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce1.Data.Order", "Orders")
                        .WithMany("Order_Details")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUsers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Data.Payment", b =>
                {
                    b.HasOne("Ecommerce1.Data.Order", "Orders")
                        .WithMany("Payment")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Data.Product", b =>
                {
                    b.HasOne("Ecommerce1.Data.Discount", "Discount")
                        .WithMany("Product")
                        .HasForeignKey("Id_discount");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("Ecommerce1.Data.Shopping_Session", b =>
                {
                    b.HasOne("Ecommerce1.Models.AppUsers", "AppUser")
                        .WithMany("ShoppingSessions")
                        .HasForeignKey("Id_AppUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Ecommerce1.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Ecommerce1.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce1.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Ecommerce1.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce1.Data.Discount", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce1.Data.Order", b =>
                {
                    b.Navigation("Order_Details");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Ecommerce1.Data.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Models.AppUsers", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ShoppingSessions");
                });
#pragma warning restore 612, 618
        }
    }
}