﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapidersi.Repositories;

#nullable disable

namespace webapidersi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230814185658_config")]
    partial class config
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapidersi.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("webapidersi.Models.Exhibition", b =>
                {
                    b.Property<int>("ExhibitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExhibitionId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExhibitionId");

                    b.ToTable("Exhibitions");

                    b.HasData(
                        new
                        {
                            ExhibitionId = 1,
                            Description = "kskskjfjffsf",
                            Name = "Hikayelerin Hikayesi"
                        },
                        new
                        {
                            ExhibitionId = 2,
                            Description = "aaaaa",
                            Name = "Varoluş ve Yüzey"
                        });
                });

            modelBuilder.Entity("webapidersi.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("webapidersi.Models.Museum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("WorkID");

                    b.ToTable("Museums");
                });

            modelBuilder.Entity("webapidersi.Models.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fallowers")
                        .HasColumnType("int");

                    b.Property<int>("Fallowing")
                        .HasColumnType("int");

                    b.Property<string>("Favorites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("webapidersi.Models.Work", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("ExhibitionId")
                        .HasColumnType("int");

                    b.Property<string>("Kunye")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ExhibitionId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("webapidersi.Models.Museum", b =>
                {
                    b.HasOne("webapidersi.Models.Work", null)
                        .WithMany("Museums")
                        .HasForeignKey("WorkID");
                });

            modelBuilder.Entity("webapidersi.Models.Work", b =>
                {
                    b.HasOne("webapidersi.Models.Artist", "Artist")
                        .WithMany("Works")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapidersi.Models.Exhibition", "Exhibition")
                        .WithMany()
                        .HasForeignKey("ExhibitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Exhibition");
                });

            modelBuilder.Entity("webapidersi.Models.Artist", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("webapidersi.Models.Work", b =>
                {
                    b.Navigation("Museums");
                });
#pragma warning restore 612, 618
        }
    }
}
