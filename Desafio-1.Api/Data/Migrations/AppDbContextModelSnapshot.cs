﻿// <auto-generated />
using System;
using Desafio_1.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio_1.Api.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Desafio_1.Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantityStock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Notebook",
                            Price = 2900.99m,
                            QuantityStock = 100
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mouse",
                            Price = 49.99m,
                            QuantityStock = 200
                        },
                        new
                        {
                            Id = 3,
                            Name = "Teclado",
                            Price = 109.97m,
                            QuantityStock = 150
                        },
                        new
                        {
                            Id = 4,
                            Name = "Monitor",
                            Price = 999.99m,
                            QuantityStock = 50
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tablet",
                            Price = 1200.99m,
                            QuantityStock = 75
                        });
                });

            modelBuilder.Entity("Desafio_1.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}