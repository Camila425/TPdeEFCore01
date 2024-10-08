﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPdeEFCore01.Datos;

#nullable disable

namespace TPdeEFCore01.Datos.Migrations
{
    [DbContext(typeof(ShoesDbContext))]
    [Migration("20240609183822_CreacionTablaSizes")]
    partial class CreacionTablaSizes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TPdeEFCore01.Entidades.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Adidas"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "Nike"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "Puma"
                        });
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColorId");

                    b.HasIndex("ColorName")
                        .IsUnique();

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "Rojo"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Blanco"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Negro"
                        });
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Correr"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Futbol"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Baloncesto"
                        });
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("SportId");

                    b.ToTable("shoes");

                    b.HasData(
                        new
                        {
                            ShoeId = 1,
                            BrandId = 1,
                            ColorId = 0,
                            Description = "con tres rayas blancas laterales",
                            GenreId = 1,
                            Model = "Samba",
                            Price = 8999000m,
                            SportId = 1
                        },
                        new
                        {
                            ShoeId = 2,
                            BrandId = 2,
                            ColorId = 0,
                            Description = "Zapatillas para correr con tecnología",
                            GenreId = 2,
                            Model = " Air Max 270",
                            Price = 12999m,
                            SportId = 2
                        },
                        new
                        {
                            ShoeId = 3,
                            BrandId = 3,
                            ColorId = 0,
                            Description = "Zapatillas de Volleyball",
                            GenreId = 3,
                            Model = "  clyde all-pro",
                            Price = 10999m,
                            SportId = 3
                        });
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<double>("SizeNumber")
                        .HasColumnType("float");

                    b.HasKey("SizeId");

                    b.HasIndex("SizeNumber")
                        .IsUnique();

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Sport", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportId"));

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SportId");

                    b.HasIndex("SportName")
                        .IsUnique();

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = 1,
                            SportName = "Tennis"
                        },
                        new
                        {
                            SportId = 2,
                            SportName = "Basketball"
                        },
                        new
                        {
                            SportId = 3,
                            SportName = "Volleyball"
                        });
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Shoe", b =>
                {
                    b.HasOne("TPdeEFCore01.Entidades.Brand", "brand")
                        .WithMany("shoes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPdeEFCore01.Entidades.Color", "color")
                        .WithMany("shoes")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPdeEFCore01.Entidades.Genre", "genre")
                        .WithMany("shoes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPdeEFCore01.Entidades.Sport", "sport")
                        .WithMany("shoes")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("color");

                    b.Navigation("genre");

                    b.Navigation("sport");
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Brand", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Color", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Genre", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("TPdeEFCore01.Entidades.Sport", b =>
                {
                    b.Navigation("shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
