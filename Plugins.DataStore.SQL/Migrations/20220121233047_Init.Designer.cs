﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQL;

namespace Plugins.DataStore.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20220121233047_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Beverage",
                            Name = "Beverage"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Bakery",
                            Name = "Bakery"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Meat",
                            Name = "Meat"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Iced Tea",
                            Price = 1.99,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "Canada Dry",
                            Price = 1.99,
                            Quantity = 200
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Name = "Whole Wheat Bread",
                            Price = 1.5,
                            Quantity = 300
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Name = "White Bread",
                            Price = 1.5,
                            Quantity = 300
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeforeQty")
                        .HasColumnType("int");

                    b.Property<string>("CashierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoldQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
