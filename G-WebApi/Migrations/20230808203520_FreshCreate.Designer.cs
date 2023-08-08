﻿// <auto-generated />
using G_WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace G_WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230808203520_FreshCreate")]
    partial class FreshCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("G_WebApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DC Studio"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Marvel Studio"
                        });
                });

            modelBuilder.Entity("G_WebApi.Models.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SuperHeroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            FirstName = "Peter",
                            LastName = "Parker",
                            Name = "Spider Man",
                            Place = "New York City"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            FirstName = "Tony",
                            LastName = "Stack",
                            Name = "Iron Man",
                            Place = "Malibu"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            FirstName = "Chris",
                            LastName = "B",
                            Name = "Thor",
                            Place = "Asgaurd"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            Name = "Bat Man",
                            Place = "Gotham City"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            FirstName = "T",
                            LastName = "Chala",
                            Name = "Black Pantar",
                            Place = "Wakanda"
                        });
                });

            modelBuilder.Entity("G_WebApi.Models.SuperHero", b =>
                {
                    b.HasOne("G_WebApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
