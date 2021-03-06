// <auto-generated />
using System;
using BookingManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingManagement.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingManagement.Model.BookflightTbl", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("EmailId")
                        .HasMaxLength(50);

                    b.Property<string>("FlightNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Meal")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Pnr")
                        .HasMaxLength(50);

                    b.Property<int?>("peopleid")
                        .HasColumnName("peopleid");

                    b.HasKey("Id");

                    b.ToTable("bookflightTbl");
                });

            modelBuilder.Entity("BookingManagement.Model.InventoryDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessClassSeat");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<string>("FlightNo");

                    b.Property<string>("FromPlace");

                    b.Property<int>("Meal");

                    b.Property<int>("NoOfRows");

                    b.Property<int>("NonBusinessClassSeat");

                    b.Property<double>("Price");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<string>("ToPlace");

                    b.HasKey("id");

                    b.ToTable("InventoryTbls");
                });

            modelBuilder.Entity("BookingManagement.Model.UserDetailTbl", b =>
                {
                    b.Property<int>("PeopleId")
                        .HasColumnName("PeopleId");

                    b.Property<string>("Age")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("Class")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.HasKey("PeopleId");

                    b.ToTable("UserDetailTbl");
                });
#pragma warning restore 612, 618
        }
    }
}
