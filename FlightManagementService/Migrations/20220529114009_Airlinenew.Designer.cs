// <auto-generated />
using FlightManagementService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightManagementService.Migrations
{
    [DbContext(typeof(AirlineDBContext))]
    [Migration("20220529114009_Airlinenew")]
    partial class Airlinenew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
