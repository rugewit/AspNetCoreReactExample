﻿// <auto-generated />
using AspNetServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetServer.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220729132853_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("AspNetServer.Data.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Content = "This is Post 1 and it has very intresting content",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            Content = "This is Post 2 and it has very intresting content",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            Content = "This is Post 3 and it has very intresting content",
                            Title = "Post 3"
                        },
                        new
                        {
                            PostId = 4,
                            Content = "This is Post 4 and it has very intresting content",
                            Title = "Post 4"
                        },
                        new
                        {
                            PostId = 5,
                            Content = "This is Post 5 and it has very intresting content",
                            Title = "Post 5"
                        },
                        new
                        {
                            PostId = 6,
                            Content = "This is Post 6 and it has very intresting content",
                            Title = "Post 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
