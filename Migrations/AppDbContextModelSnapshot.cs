﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using neighborhoodFlavors.Data;

#nullable disable

namespace trabalhofinal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentText = "Comida muito boa!",
                            MenuId = 1,
                            PublishDate = new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(433),
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            CommentText = "Atendimento excelente",
                            MenuId = 2,
                            PublishDate = new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(480),
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CommentText = "Pouca variedade de pratos",
                            MenuId = 1,
                            PublishDate = new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(486),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CommentText = "Recomendo o restaurante",
                            MenuId = 2,
                            PublishDate = new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(491),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemName = "Carne bovina"
                        },
                        new
                        {
                            Id = 2,
                            ItemName = "Carne Suina"
                        },
                        new
                        {
                            Id = 3,
                            ItemName = "Couve de Flor"
                        },
                        new
                        {
                            Id = 4,
                            ItemName = "Arroz"
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.ItemMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("MenuId");

                    b.ToTable("ItemMenus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 1,
                            MenuId = 1
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 2,
                            MenuId = 2
                        },
                        new
                        {
                            Id = 3,
                            ItemId = 3,
                            MenuId = 1
                        },
                        new
                        {
                            Id = 4,
                            ItemId = 4,
                            MenuId = 2
                        },
                        new
                        {
                            Id = 5,
                            ItemId = 1,
                            MenuId = 3
                        },
                        new
                        {
                            Id = 6,
                            ItemId = 2,
                            MenuId = 3
                        },
                        new
                        {
                            Id = 7,
                            ItemId = 3,
                            MenuId = 3
                        },
                        new
                        {
                            Id = 8,
                            ItemId = 4,
                            MenuId = 3
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("avgRating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RestaurantId = 1,
                            avgRating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            RestaurantId = 2,
                            avgRating = 4.0
                        },
                        new
                        {
                            Id = 3,
                            RestaurantId = 1,
                            avgRating = 4.75
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuId = 1,
                            Score = 5,
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            MenuId = 2,
                            Score = 4,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            MenuId = 1,
                            Score = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            MenuId = 2,
                            Score = 5,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cozinharte",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Suzy",
                            UserId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "suzy@gmail.com",
                            Name = "Suzy",
                            Password = "senha123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "cozinharte@gmail.com",
                            Name = "Cozinharte",
                            Password = "senha456"
                        },
                        new
                        {
                            Id = 3,
                            Email = "filipe@gmail.com",
                            Name = "Filipe",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Comment", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Menu", null)
                        .WithMany("Comments")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neighborhoodFlavors.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.ItemMenu", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Item", "Item")
                        .WithMany("ItemMenus")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neighborhoodFlavors.Data.Menu", "Menu")
                        .WithMany("ItemMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Restaurant", null)
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Rating", b =>
                {
                    b.HasOne("neighborhoodFlavors.Data.Menu", null)
                        .WithMany("Ratings")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neighborhoodFlavors.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Item", b =>
                {
                    b.Navigation("ItemMenus");
                });

            modelBuilder.Entity("neighborhoodFlavors.Data.Menu", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ItemMenus");

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
