﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using neighborhoodFlavors.Data;

#nullable disable

namespace trabalhofinal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240907175457_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("neighborhoodFlavors.Data.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MenuId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("avgRating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Comment", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Menu", null)
                        .WithMany("Comments")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Item", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Menu", null)
                        .WithMany("Itens")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Restaurant", null)
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Rating", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Menu", null)
                        .WithMany("Ratings")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Itens");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Restaurant", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
