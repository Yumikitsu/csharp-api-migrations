﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.pizzashopapi.Data;

#nullable disable

namespace exercise.pizzashopapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Name = "Patrick the Dinosaur"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Princess Squarepants"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Princess Mario"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Donkey the Dinosaur"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Luigi Peach"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Spongebob the Hedgehog"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Luigi the Echidna"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sonic Mario"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Patrick Daisy"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sonic the Hedgehog"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sonic Star"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Yoshi Squarepants"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sandy Squarepants"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Sonic the Echidna"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Yoshi the Hedgehog"
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
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 0, 14, 0)
                        },
                        new
                        {
                            CustomerId = 2,
                            PizzaId = 2,
                            Id = 2,
                            Status = 2,
                            TimeLeft = new TimeSpan(0, 0, 4, 13, 0)
                        },
                        new
                        {
                            CustomerId = 3,
                            PizzaId = 3,
                            Id = 3,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 1, 0, 0)
                        },
                        new
                        {
                            CustomerId = 4,
                            PizzaId = 4,
                            Id = 4,
                            Status = 2,
                            TimeLeft = new TimeSpan(0, 0, 7, 4, 0)
                        },
                        new
                        {
                            CustomerId = 5,
                            PizzaId = 5,
                            Id = 5,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 1, 54, 0)
                        },
                        new
                        {
                            CustomerId = 6,
                            PizzaId = 6,
                            Id = 6,
                            Status = 2,
                            TimeLeft = new TimeSpan(0, 0, 4, 14, 0)
                        },
                        new
                        {
                            CustomerId = 7,
                            PizzaId = 7,
                            Id = 7,
                            Status = 2,
                            TimeLeft = new TimeSpan(0, 0, 8, 55, 0)
                        },
                        new
                        {
                            CustomerId = 8,
                            PizzaId = 8,
                            Id = 8,
                            Status = 2,
                            TimeLeft = new TimeSpan(0, 0, 1, 3, 0)
                        },
                        new
                        {
                            CustomerId = 9,
                            PizzaId = 9,
                            Id = 9,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 2, 55, 0)
                        },
                        new
                        {
                            CustomerId = 10,
                            PizzaId = 10,
                            Id = 10,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 0, 31, 0)
                        },
                        new
                        {
                            CustomerId = 11,
                            PizzaId = 11,
                            Id = 11,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 0, 38, 0)
                        },
                        new
                        {
                            CustomerId = 12,
                            PizzaId = 12,
                            Id = 12,
                            Status = 0,
                            TimeLeft = new TimeSpan(0, 0, 1, 7, 0)
                        },
                        new
                        {
                            CustomerId = 13,
                            PizzaId = 13,
                            Id = 13,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 5, 8, 0)
                        },
                        new
                        {
                            CustomerId = 14,
                            PizzaId = 14,
                            Id = 14,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 8, 12, 0)
                        },
                        new
                        {
                            CustomerId = 15,
                            PizzaId = 15,
                            Id = 15,
                            Status = 1,
                            TimeLeft = new TimeSpan(0, 0, 6, 1, 0)
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
                            Name = "Dirt & Sardine Pizza",
                            Price = 8m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tomato Pizza",
                            Price = 9m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Grass & Sardine Pizza",
                            Price = 14m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tomato & California Reaper Pizza",
                            Price = 16m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cheese & Despair Pizza",
                            Price = 11m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Candy Pizza",
                            Price = 15m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Dirt & California Reaper Pizza",
                            Price = 19m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dirt & Sardine Pizza",
                            Price = 13m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cheese Pizza",
                            Price = 12m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Depression & Cheese Pizza",
                            Price = 14m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Concrete & Expired Milk Pizza",
                            Price = 9m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Mold & Despair Pizza",
                            Price = 14m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Mold & Expired Milk Pizza",
                            Price = 15m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Cheese & Expired Milk Pizza",
                            Price = 8m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Depression & Despair Pizza",
                            Price = 18m
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
