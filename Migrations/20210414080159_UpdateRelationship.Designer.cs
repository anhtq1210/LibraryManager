﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_12_04.Data;

namespace WebAPI_12_04.Migrations
{
    [DbContext(typeof(LibDbContext))]
    [Migration("20210414080159_UpdateRelationship")]
    partial class UpdateRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI_12_04.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublicDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Request", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.RequestDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("RequestID");

                    b.ToTable("RequestDetail");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Passwords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Book", b =>
                {
                    b.HasOne("WebAPI_12_04.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Request", b =>
                {
                    b.HasOne("WebAPI_12_04.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.RequestDetail", b =>
                {
                    b.HasOne("WebAPI_12_04.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID");

                    b.HasOne("WebAPI_12_04.Models.Request", "Request")
                        .WithMany("RequestDetail")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.User", b =>
                {
                    b.HasOne("WebAPI_12_04.Models.Role", "UserRole")
                        .WithMany("User")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Request", b =>
                {
                    b.Navigation("RequestDetail");
                });

            modelBuilder.Entity("WebAPI_12_04.Models.Role", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
