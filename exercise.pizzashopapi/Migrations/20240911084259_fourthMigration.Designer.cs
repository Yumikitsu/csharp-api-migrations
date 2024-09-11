﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.pizzashopapi.Data;

#nullable disable

namespace exercise.pizzashopapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240911084259_fourthMigration")]
    partial class fourthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("exercise.pizzashopapi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Luigi the Hedgehog"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sonic the Dinosaur"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patrick the Dinosaur"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sonic Star"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Donkey Mario"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sonic Daisy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Yoshi the Dinosaur"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Luigi Star"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Princess Star"
                        });
                });

            modelBuilder.Entity("exercise.pizzashopapi.Models.Order", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customerId");

                    b.Property<int>("PizzaId")
                        .HasColumnType("integer")
                        .HasColumnName("pizzaId");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("orderStatus");

                    b.Property<TimeSpan>("TimeLeft")
                        .HasColumnType("interval")
                        .HasColumnName("timeLeft");

                    b.HasKey("CustomerId", "PizzaId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("PizzaId")
                        .IsUnique();

                    b.ToTable("orders");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            PizzaId = 1,
                            Id = 1,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 4, 11, 0)
                        },
                        new
                        {
                            CustomerId = 2,
                            PizzaId = 2,
                            Id = 2,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 1, 27, 0)
                        },
                        new
                        {
                            CustomerId = 3,
                            PizzaId = 3,
                            Id = 3,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 0, 8, 0)
                        },
                        new
                        {
                            CustomerId = 4,
                            PizzaId = 4,
                            Id = 4,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 2, 42, 0)
                        },
                        new
                        {
                            CustomerId = 5,
                            PizzaId = 5,
                            Id = 5,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 10, 1, 0)
                        },
                        new
                        {
                            CustomerId = 6,
                            PizzaId = 6,
                            Id = 6,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 8, 38, 0)
                        },
                        new
                        {
                            CustomerId = 7,
                            PizzaId = 7,
                            Id = 7,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 1, 1, 0)
                        },
                        new
                        {
                            CustomerId = 8,
                            PizzaId = 8,
                            Id = 8,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 5, 9, 0)
                        },
                        new
                        {
                            CustomerId = 9,
                            PizzaId = 9,
                            Id = 9,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 8, 56, 0)
                        });
                });

            modelBuilder.Entity("exercise.pizzashopapi.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Grass & California Reaper Pizza",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mold & Despair Pizza",
                            Price = 11m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mold & Despair Pizza",
                            Price = 18m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tomato & Ketchup Pizza",
                            Price = 19m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dirt & Cheese Pizza",
                            Price = 10m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Depression & Ketchup Pizza",
                            Price = 16m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mold & California Reaper Pizza",
                            Price = 19m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Grass & Cheese Pizza",
                            Price = 16m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Depression & Expired Milk Pizza",
                            Price = 17m
                        });
                });

            modelBuilder.Entity("exercise.pizzashopapi.Models.Order", b =>
                {
                    b.HasOne("exercise.pizzashopapi.Models.Customer", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("exercise.pizzashopapi.Models.Order", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("exercise.pizzashopapi.Models.Pizza", "Pizza")
                        .WithOne("Order")
                        .HasForeignKey("exercise.pizzashopapi.Models.Order", "PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("exercise.pizzashopapi.Models.Customer", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("exercise.pizzashopapi.Models.Pizza", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
