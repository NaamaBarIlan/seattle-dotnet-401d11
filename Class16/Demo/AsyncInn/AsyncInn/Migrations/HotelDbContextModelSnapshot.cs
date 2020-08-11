﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Coffee Maker"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Jacuzzi Tub"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Netflix"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Petting Zoo"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "123 Seattle Way",
                            Name = "Emerald City Stay",
                            Phone = "123-456-7654"
                        },
                        new
                        {
                            ID = 2,
                            Address = "123 LasVegas Strip Way",
                            Name = "Las Vegas Strip",
                            Phone = "123-876-1946"
                        },
                        new
                        {
                            ID = 3,
                            Address = "987 Dizney Way",
                            Name = "Disney Adventures",
                            Phone = "481-512-3421"
                        },
                        new
                        {
                            ID = 4,
                            Address = "84 Treasure Way",
                            Name = "Pirates Life",
                            Phone = "975-588-9621"
                        },
                        new
                        {
                            ID = 5,
                            Address = "123 Fancy Way",
                            Name = "Grand Excursion",
                            Phone = "493-396-9785"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "Seahawks Snooze"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 0,
                            Name = "Restful Rainier"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "Couples Retreat"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 2,
                            Name = "Officially Business"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 0,
                            Name = "The Playhouse"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 1,
                            Name = "The Staycation"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("AmenitiesID")
                        .HasColumnType("int");

                    b.HasKey("RoomID", "AmenitiesID");

                    b.HasIndex("AmenitiesID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithMany()
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
