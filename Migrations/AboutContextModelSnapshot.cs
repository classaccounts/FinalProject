﻿// <auto-generated />
using System;
using FinalProjectWebServerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProjectWebServerApp.Migrations
{
    [DbContext(typeof(AboutContext))]
    partial class AboutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProjectWebServerApp.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("HobbyId");

                    b.HasIndex("StudentId");

                    b.ToTable("Hobby");
                });

            modelBuilder.Entity("FinalProjectWebServerApp.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Name = "Jack"
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Alex"
                        });
                });

            modelBuilder.Entity("FinalProjectWebServerApp.Models.Hobby", b =>
                {
                    b.HasOne("FinalProjectWebServerApp.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
