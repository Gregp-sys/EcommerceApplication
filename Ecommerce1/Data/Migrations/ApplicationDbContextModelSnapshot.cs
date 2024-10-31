﻿// <auto-generated />
using System;
using Ecommerce1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Shop_Session")
                        .HasColumnType("int");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_cart");

                    b.HasIndex("Id_Shop_Session");

                    b.HasIndex("Id_product");

                    b.ToTable("CartItems");
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_AppUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Shop_Session");

                    b.HasIndex("Id_AppUser");

                    b.ToTable("ShoppingSessions");
                });

            modelBuilder.Entity("Ecommerce1.Models.AppRole", b =>
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

            modelBuilder.Entity("Ecommerce1.Models.AppUsers", b =>
                {
                    b.Property<int>("Id_Appuser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Appuser"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

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
                    b.HasOne("Ecommerce1.Models.AppRole", null)
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
                    b.HasOne("Ecommerce1.Models.AppRole", null)
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
