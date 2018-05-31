﻿// <auto-generated />
using BicycleShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BicycleShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180520131202_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BicycleShop.Models.Bike", b =>
                {
                    b.Property<int>("BikeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsBikeOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Model");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("BikeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("BicycleShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BicycleShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BicycleShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("BikeId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BikeId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BicycleShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int?>("BikeId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("BikeId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("BicycleShop.Models.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bell");

                    b.Property<int>("BikeId");

                    b.Property<string>("BrakeDiscs");

                    b.Property<string>("Brakes");

                    b.Property<string>("Cassette");

                    b.Property<string>("Chain");

                    b.Property<string>("Color");

                    b.Property<string>("Crank");

                    b.Property<string>("Derailleur");

                    b.Property<string>("Fork");

                    b.Property<string>("Frame");

                    b.Property<string>("FrameSize");

                    b.Property<string>("FrontHub");

                    b.Property<string>("Grips");

                    b.Property<string>("Handlebar");

                    b.Property<string>("Headlight");

                    b.Property<string>("Headset");

                    b.Property<string>("InnerBearing");

                    b.Property<string>("Pedals");

                    b.Property<string>("RearDerailleur");

                    b.Property<string>("RearHub");

                    b.Property<string>("RearLight");

                    b.Property<string>("RearRack");

                    b.Property<string>("RearSuspension");

                    b.Property<string>("Rims");

                    b.Property<string>("Saddle");

                    b.Property<string>("Seatpost");

                    b.Property<string>("Shifter");

                    b.Property<string>("Splashguard");

                    b.Property<string>("Spokes");

                    b.Property<string>("Stand");

                    b.Property<string>("Steam");

                    b.Property<string>("Tires");

                    b.Property<string>("TravelFork");

                    b.Property<string>("TravelRearSuspension");

                    b.Property<string>("Weight");

                    b.Property<string>("Wheelset");

                    b.HasKey("Id");

                    b.HasIndex("BikeId")
                        .IsUnique();

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("BicycleShop.Models.Bike", b =>
                {
                    b.HasOne("BicycleShop.Models.Category", "Category")
                        .WithMany("Bikes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BicycleShop.Models.OrderDetail", b =>
                {
                    b.HasOne("BicycleShop.Models.Bike", "Bike")
                        .WithMany()
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BicycleShop.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BicycleShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("BicycleShop.Models.Bike", "Bike")
                        .WithMany()
                        .HasForeignKey("BikeId");
                });

            modelBuilder.Entity("BicycleShop.Models.Specification", b =>
                {
                    b.HasOne("BicycleShop.Models.Bike", "Bike")
                        .WithOne("Specifications")
                        .HasForeignKey("BicycleShop.Models.Specification", "BikeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
