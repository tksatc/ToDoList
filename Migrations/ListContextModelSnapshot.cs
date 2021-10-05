﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoList.Models;

namespace ToDoList.Migrations
{
    [DbContext(typeof(ListContext))]
    partial class ListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoList.Models.TheList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GetItDone");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Do CIT228 Homework"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Take a nap"
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Work Out"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
