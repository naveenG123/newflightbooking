﻿// <auto-generated />
using System;
using FlightManagementService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightManagementService.Migrations
{
    [DbContext(typeof(AirlineDBContext))]
    partial class AirlineDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlightManagementService.Model.AirlineDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("AirlineName");

                    b.Property<string>("AirlineNo");

                    b.Property<string>("Logo");

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.ToTable("airlineTbls");
                });

            modelBuilder.Entity("FlightManagementService.Model.InventoryDetails", b =>
                {
                    b.Property<string>("FlightNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirlineNo");

                    b.Property<int?>("BusinessClassSeat");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<string>("FromPlace");

                    b.Property<string>("InstrumentUsed");

                    b.Property<string>("Meal");

                    b.Property<int?>("NoOfRows");

                    b.Property<int?>("NonBusinessClassSeat");

                    b.Property<string>("ScheduleDays");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<decimal?>("TicketCost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("ToPlace");

                    b.HasKey("FlightNumber");

                    b.ToTable("inventoryTbls");
                });
#pragma warning restore 612, 618
        }
    }
}