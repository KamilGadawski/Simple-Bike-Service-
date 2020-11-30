﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceAPI.DbContexts;

namespace ServiceAPI.Migrations
{
    [DbContext(typeof(BikeCustomerContext))]
    partial class BikeCustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ServiceAPI.Entities.Bike", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedBike")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Size")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bikes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d719c835-ce3e-4dad-ad64-cfec54b19775"),
                            AddedBike = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "Giant",
                            CustomerID = new Guid("65da4ed0-35b9-454e-b5ac-d0eee7aad646"),
                            Description = "Repair front wheel",
                            Model = "TCR",
                            Size = 54
                        },
                        new
                        {
                            Id = new Guid("e6e46660-bb84-451d-aafe-a6c7346a48ae"),
                            AddedBike = new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "Kross",
                            CustomerID = new Guid("65da4ed0-35b9-454e-b5ac-d0eee7aad646"),
                            Description = "Change Casette",
                            Model = "Vento 5.0",
                            Size = 58
                        },
                        new
                        {
                            Id = new Guid("99289c1a-3342-40fc-905b-65c2dd59babe"),
                            AddedBike = new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "Merida",
                            CustomerID = new Guid("65da4ed0-35b9-454e-b5ac-d0eee7aad646"),
                            Description = "Change chain",
                            Model = "Reacto 4000",
                            Size = 56
                        });
                });

            modelBuilder.Entity("ServiceAPI.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BikeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTimeAdd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BikeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a7d64d6-b3f4-42da-90cc-e616c3afdc7b"),
                            BikeId = new Guid("99289c1a-3342-40fc-905b-65c2dd59babe"),
                            DateTimeAdd = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john@gmail.com",
                            Name = "Johon",
                            Surname = "Wallie",
                            TelephoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("3c7ddfb9-cfb4-4b97-a95a-8510ecb707d1"),
                            BikeId = new Guid("e6e46660-bb84-451d-aafe-a6c7346a48ae"),
                            DateTimeAdd = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mark@gmail.com",
                            Name = "Mark",
                            Surname = "Tree",
                            TelephoneNumber = "234567891"
                        },
                        new
                        {
                            Id = new Guid("65da4ed0-35b9-454e-b5ac-d0eee7aad646"),
                            BikeId = new Guid("99289c1a-3342-40fc-905b-65c2dd59babe"),
                            DateTimeAdd = new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "peter@gmail.com",
                            Name = "Peter",
                            Surname = "Kowalsky",
                            TelephoneNumber = "434567891"
                        });
                });

            modelBuilder.Entity("ServiceAPI.Entities.Customer", b =>
                {
                    b.HasOne("ServiceAPI.Entities.Bike", "Bike")
                        .WithMany("Repairs")
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bike");
                });

            modelBuilder.Entity("ServiceAPI.Entities.Bike", b =>
                {
                    b.Navigation("Repairs");
                });
#pragma warning restore 612, 618
        }
    }
}
