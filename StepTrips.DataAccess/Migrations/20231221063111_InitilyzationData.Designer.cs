﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StepTrips.DataAccess;

#nullable disable

namespace StepTrips.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231221063111_InitilyzationData")]
    partial class InitilyzationData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StepTrips.DataContract.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Addriss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessSeats")
                        .HasColumnType("int");

                    b.Property<int>("EconomySeats")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Plane")
                        .HasColumnType("int");

                    b.Property<int?>("PlanesId")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceOfBusiness")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceOfEconomy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TripCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TripFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TripTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TripTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlanesId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.TripReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<int>("PlaneId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("TripStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TripTypesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CountryId");

                    b.HasIndex("PlaneId");

                    b.HasIndex("TripId");

                    b.HasIndex("TripStatusId");

                    b.HasIndex("TripTypesId");

                    b.ToTable("TripReservations");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.TripStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TripStatuses");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.TripType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TripTypes");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.Trip", b =>
                {
                    b.HasOne("StepTrips.DataContract.Model.Plane", "Planes")
                        .WithMany()
                        .HasForeignKey("PlanesId");

                    b.Navigation("Planes");
                });

            modelBuilder.Entity("StepTrips.DataContract.Model.TripReservation", b =>
                {
                    b.HasOne("StepTrips.DataContract.Model.Client", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepTrips.DataContract.Model.Country", "Countries")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepTrips.DataContract.Model.Plane", "Planes")
                        .WithMany()
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepTrips.DataContract.Model.Trip", "Trips")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepTrips.DataContract.Model.TripStatus", "TripStatus")
                        .WithMany()
                        .HasForeignKey("TripStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepTrips.DataContract.Model.TripType", "TripTypes")
                        .WithMany()
                        .HasForeignKey("TripTypesId");

                    b.Navigation("Clients");

                    b.Navigation("Countries");

                    b.Navigation("Planes");

                    b.Navigation("TripStatus");

                    b.Navigation("TripTypes");

                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
