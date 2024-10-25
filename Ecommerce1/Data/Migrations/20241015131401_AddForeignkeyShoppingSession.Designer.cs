﻿// <auto-generated />
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
    [Migration("20241015131401_AddForeignkeyShoppingSession")]
    partial class AddForeignkeyShoppingSession
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce1.Models.Cart_item", b =>
                {
                    b.Property<int>("Id_cart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cart"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Total_Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_cart");

                    b.ToTable("Cart_item");
                });

            modelBuilder.Entity("Ecommerce1.Models.Discount", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_discount");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order", b =>
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

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Order");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order_Details", b =>
                {
                    b.Property<int>("Id_details")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_details"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_details");

                    b.ToTable("Order_Detail");
                });

            modelBuilder.Entity("Ecommerce1.Models.Payment", b =>
                {
                    b.Property<int>("Id_payments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_payments"));

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_payments");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Ecommerce1.Models.Product", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_product");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce1.Models.Shopping_Session", b =>
                {
                    b.Property<int>("Id_Shop_Session")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Shop_Session"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Total_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Shop_Session");

                    b.HasIndex("Id_user");

                    b.ToTable("Shopping_Sessions");
                });

            modelBuilder.Entity("Ecommerce1.Models.User", b =>
                {
                    b.Property<int>("Id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_User"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_User");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id_User = 1,
                            Adress = "1234 Elm St, Springfield",
                            Created = "2023-10-01 10:30:00",
                            Email = "john.doe@gmail.com",
                            Name = "John",
                            Password = "gM}56fjg",
                            Phone_number = "+1 555-123-4567",
                            Surname = "Doe",
                            modified = "2023-10-10 12:45:00"
                        },
                        new
                        {
                            Id_User = 2,
                            Adress = "5678 Oak St, Greenfield",
                            Created = "2023-10-02 11:20:00",
                            Email = "jane.smith@protonmail.com",
                            Name = "Jane",
                            Password = ">3LUmc=RvyGRHW%g/-~z",
                            Phone_number = "+1 555-987-6543",
                            Surname = "Smith",
                            modified = "2023-10-11 15:00:00"
                        },
                        new
                        {
                            Id_User = 3,
                            Adress = "9101 Pine St, Brookfield",
                            Created = "2023-10-03 14:45:00",
                            Email = "mark.williams@domain.com",
                            Name = "Mark",
                            Password = "x*D5-UV/89`&^_q,v-H7",
                            Phone_number = "+1 555-321-7654",
                            Surname = "Williams",
                            modified = "2023-10-12 09:10:00"
                        },
                        new
                        {
                            Id_User = 4,
                            Adress = "2468 Maple St, Hilltown",
                            Created = "2023-10-04 09:50:00",
                            Email = "emma.jones@outlook.com",
                            Name = "Emma",
                            Password = "fCxwnchJs1w|-S}YA>-F",
                            Phone_number = "+1 555-654-3210",
                            Surname = "Jones",
                            modified = "2023-10-11 16:30:00"
                        },
                        new
                        {
                            Id_User = 5,
                            Adress = "1357 Birch St, Riverview",
                            Created = "2023-10-05 08:30:00",
                            Email = "robert.brown@yahoo.com",
                            Name = "Robert",
                            Password = "(y.<vQ3[8w*]KYgMs3ab",
                            Phone_number = "+1 555-555-7890",
                            Surname = "Brown",
                            modified = "2023-10-12 14:20:00"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Models.Shopping_Session", b =>
                {
                    b.HasOne("Ecommerce1.Models.User", "User")
                        .WithMany("Shopping_Sessions")
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce1.Models.User", b =>
                {
                    b.Navigation("Shopping_Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
