﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi;

#nullable disable

namespace MyApi.Migrations
{
    [DbContext(typeof(WiesDB))]
    [Migration("20240320182153_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("MyApi.WIES", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isValid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("requestDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("userError")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Wieses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "Polna 2",
                            isValid = true,
                            name = "Biedronka"
                        },
                        new
                        {
                            Id = 2,
                            address = "Polna 3",
                            isValid = true,
                            name = "Lidl"
                        },
                        new
                        {
                            Id = 3,
                            address = "Polna 4",
                            isValid = true,
                            name = "OBI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
