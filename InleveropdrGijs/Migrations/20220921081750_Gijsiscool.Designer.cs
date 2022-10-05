﻿// <auto-generated />
using System;
using InleveropdrGijs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InleveropdrGijs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220921081750_Gijsiscool")]
    partial class Gijsiscool
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CameraFoto", b =>
                {
                    b.Property<int>("CameraID")
                        .HasColumnType("int");

                    b.Property<int>("FotoID")
                        .HasColumnType("int");

                    b.HasKey("CameraID", "FotoID");

                    b.HasIndex("FotoID");

                    b.ToTable("CameraFoto");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AantalVrienden")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Punten")
                        .HasColumnType("int");

                    b.Property<string>("klantNaam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CameraID"), 1L, 1);

                    b.Property<int>("AantalBevestigd")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CameraID");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Foto", b =>
                {
                    b.Property<int>("FotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FotoID"), 1L, 1);

                    b.Property<int>("AantalFotos")
                        .HasColumnType("int");

                    b.Property<int?>("CameraID")
                        .HasColumnType("int");

                    b.HasKey("FotoID");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Locatie", b =>
                {
                    b.Property<int>("LocatieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocatieID"), 1L, 1);

                    b.Property<int?>("CameraID")
                        .HasColumnType("int");

                    b.Property<string>("plaats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocatieID");

                    b.HasIndex("CameraID");

                    b.ToTable("Locaties");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Winkel", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"), 1L, 1);

                    b.Property<string>("ItemNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prijs")
                        .HasColumnType("int");

                    b.Property<int>("Vooraad")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("Winkels");
                });

            modelBuilder.Entity("CameraFoto", b =>
                {
                    b.HasOne("InleveropdrGijs.Models.Camera", null)
                        .WithMany()
                        .HasForeignKey("CameraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InleveropdrGijs.Models.Foto", null)
                        .WithMany()
                        .HasForeignKey("FotoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Locatie", b =>
                {
                    b.HasOne("InleveropdrGijs.Models.Camera", null)
                        .WithMany("LocatieID")
                        .HasForeignKey("CameraID");
                });

            modelBuilder.Entity("InleveropdrGijs.Models.Camera", b =>
                {
                    b.Navigation("LocatieID");
                });
#pragma warning restore 612, 618
        }
    }
}
