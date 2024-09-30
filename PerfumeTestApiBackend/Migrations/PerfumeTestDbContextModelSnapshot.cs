﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PerfumeTestApiBackend.DataAccess;

#nullable disable

namespace PerfumeTestApiBackend.Migrations
{
    [DbContext(typeof(PerfumeTestDbContext))]
    partial class PerfumeTestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerfumeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfumeID");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("PerfumeID")
                        .HasColumnType("int");

                    b.Property<string>("TypeGender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PerfumeID");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Perfume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.ToTable("Perfumes");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Perfumery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Perfumerias");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Stock", b =>
                {
                    b.Property<int>("PerfumeID")
                        .HasColumnType("int");

                    b.Property<int>("PerfumeryID")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("PerfumeID", "PerfumeryID");

                    b.HasIndex("PerfumeryID");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Volume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("PerfumeID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfumeID");

                    b.ToTable("Volumes");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Brand", b =>
                {
                    b.HasOne("PerfumeTestApiBackend.Models.Perfume", "Perfume")
                        .WithMany("Brands")
                        .HasForeignKey("PerfumeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfume");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Gender", b =>
                {
                    b.HasOne("PerfumeTestApiBackend.Models.Perfume", "Perfume")
                        .WithMany("Genders")
                        .HasForeignKey("PerfumeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfume");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Stock", b =>
                {
                    b.HasOne("PerfumeTestApiBackend.Models.Perfume", "Perfume")
                        .WithMany("Stocks")
                        .HasForeignKey("PerfumeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PerfumeTestApiBackend.Models.Perfumery", "Perfumery")
                        .WithMany("Stocks")
                        .HasForeignKey("PerfumeryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfume");

                    b.Navigation("Perfumery");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Volume", b =>
                {
                    b.HasOne("PerfumeTestApiBackend.Models.Perfume", "Perfume")
                        .WithMany("Volumes")
                        .HasForeignKey("PerfumeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfume");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Perfume", b =>
                {
                    b.Navigation("Brands");

                    b.Navigation("Genders");

                    b.Navigation("Stocks");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("PerfumeTestApiBackend.Models.Perfumery", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
