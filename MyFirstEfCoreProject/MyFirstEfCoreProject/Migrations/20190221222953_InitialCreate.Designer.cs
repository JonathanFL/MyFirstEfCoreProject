﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstEfCoreProject;

namespace MyFirstEfCoreProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190221222953_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("MyFirstEfCoreProject.Model.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("hd");

                    b.Property<double>("price");

                    b.Property<int>("productId");

                    b.Property<int>("ram");

                    b.Property<double>("screen");

                    b.Property<double>("speed");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("MyFirstEfCoreProject.Model.PC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("hd");

                    b.Property<double>("price");

                    b.Property<int>("productId");

                    b.Property<int>("ram");

                    b.Property<double>("speed");

                    b.HasKey("Id");

                    b.ToTable("PCs");
                });

            modelBuilder.Entity("MyFirstEfCoreProject.Model.Printer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("color");

                    b.Property<double>("price");

                    b.Property<int>("productId");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("MyFirstEfCoreProject.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("maker");

                    b.Property<string>("model");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
