﻿// <auto-generated />
using System;
using AdDemo.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    [DbContext(typeof(AdvertisementDbContext))]
    [Migration("20220206032622_connection2")]
    partial class connection2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdDemo.Models.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AcceptedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AcceptedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("AreaofCultivation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CropId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstimatedPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Lastmodifieddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CropId");

                    b.HasIndex("VendorID");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcceptedBy = "",
                            AreaofCultivation = "50Acres",
                            CreatedBy = "Sam",
                            CreatedOn = new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CropId = 1,
                            Description = "Maize Cultivation",
                            EstimatedPrice = "Rs. 25,000.00",
                            IsAccepted = false,
                            IsAvailable = true,
                            IsDeleted = false,
                            Lastmodifieddate = new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Anuradhapura",
                            VendorID = 0
                        },
                        new
                        {
                            Id = 2,
                            AcceptedBy = "",
                            AreaofCultivation = "20Acres",
                            CreatedBy = "Peter",
                            CreatedOn = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CropId = 2,
                            Description = "Cocoa Cultivation",
                            EstimatedPrice = "Rs. 75,000.00",
                            IsAccepted = false,
                            IsAvailable = true,
                            IsDeleted = false,
                            Lastmodifieddate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Colombo",
                            VendorID = 0
                        },
                        new
                        {
                            Id = 3,
                            AcceptedBy = "",
                            AreaofCultivation = "100Acres",
                            CreatedBy = "Michael",
                            CreatedOn = new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CropId = 1,
                            Description = "Carrot Cultivation",
                            EstimatedPrice = "Rs. 100,000.00",
                            IsAccepted = false,
                            IsAvailable = true,
                            IsDeleted = false,
                            Lastmodifieddate = new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Kandy",
                            VendorID = 0
                        },
                        new
                        {
                            Id = 4,
                            AcceptedBy = "",
                            AreaofCultivation = "40Acres",
                            CreatedBy = "Mary",
                            CreatedOn = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CropId = 4,
                            Description = "Cabbage Cultivation",
                            EstimatedPrice = "Rs. 10,000.00",
                            IsAccepted = false,
                            IsAvailable = true,
                            IsDeleted = false,
                            Lastmodifieddate = new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Badulla",
                            VendorID = 0
                        });
                });

            modelBuilder.Entity("AdDemo.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoinedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modify_remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Buyers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aaa@gmail.com",
                            FullName = "Michael",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Anuradhapura",
                            Modify_remarks = "",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bbb@gmail.com",
                            FullName = "Felton",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vavniya",
                            Modify_remarks = "",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ccc@gmail.com",
                            FullName = "Harry",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Colombo",
                            Modify_remarks = "",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ddd@gmail.com",
                            FullName = "Allen",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Badulla",
                            Modify_remarks = "",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eee@gmail.com",
                            FullName = "Helen",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Chilaw",
                            Modify_remarks = "",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            DeletedBy = "",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fff@gmail.com",
                            FullName = "Ron",
                            IsActive = true,
                            IsDeleted = false,
                            IsModified = false,
                            JoinedOn = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Matara",
                            Modify_remarks = "",
                            UserId = 6
                        });
                });

            modelBuilder.Entity("AdDemo.Models.Crop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CropName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CropType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("NoOfAdvertisements")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Crops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CropName = "Carrot",
                            CropType = "Vegetables",
                            IsAvailable = true,
                            NoOfAdvertisements = 4
                        },
                        new
                        {
                            Id = 2,
                            CropName = "Beans",
                            CropType = "Vegetables",
                            IsAvailable = true,
                            NoOfAdvertisements = 1
                        },
                        new
                        {
                            Id = 3,
                            CropName = "Pears",
                            CropType = "Fruits",
                            IsAvailable = true,
                            NoOfAdvertisements = 10
                        });
                });

            modelBuilder.Entity("AdDemo.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CropId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofClosedAds")
                        .HasColumnType("int");

                    b.Property<int>("NoofInprogressAds")
                        .HasColumnType("int");

                    b.Property<int>("NoofPendingRequests")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CropId = 0,
                            FullName = "Thilini Anuradha",
                            Location = "Anuradhapura",
                            NoofClosedAds = 0,
                            NoofInprogressAds = 0,
                            NoofPendingRequests = 1
                        },
                        new
                        {
                            Id = 2,
                            CropId = 0,
                            FullName = "Piyumi Thathsarani",
                            Location = "Mathara",
                            NoofClosedAds = 3,
                            NoofInprogressAds = 1,
                            NoofPendingRequests = 4
                        },
                        new
                        {
                            Id = 3,
                            CropId = 0,
                            FullName = "Thanuja Mahendran",
                            Location = "Jaffna",
                            NoofClosedAds = 3,
                            NoofInprogressAds = 0,
                            NoofPendingRequests = 5
                        },
                        new
                        {
                            Id = 4,
                            CropId = 0,
                            FullName = "Umesha Nirmani",
                            Location = "Awissawella",
                            NoofClosedAds = 0,
                            NoofInprogressAds = 3,
                            NoofPendingRequests = 1
                        },
                        new
                        {
                            Id = 5,
                            CropId = 0,
                            FullName = "Nirmani Herath",
                            Location = "Monaragala",
                            NoofClosedAds = 0,
                            NoofInprogressAds = 5,
                            NoofPendingRequests = 4
                        },
                        new
                        {
                            Id = 6,
                            CropId = 0,
                            FullName = "Thilini Erandi",
                            Location = "Galle",
                            NoofClosedAds = 3,
                            NoofInprogressAds = 4,
                            NoofPendingRequests = 1
                        });
                });

            modelBuilder.Entity("AdDemo.Models.Advertisement", b =>
                {
                    b.HasOne("AdDemo.Models.Crop", "crop")
                        .WithMany("Advertisements")
                        .HasForeignKey("CropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdDemo.Models.Vendor", "vendor")
                        .WithMany()
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("crop");

                    b.Navigation("vendor");
                });

            modelBuilder.Entity("AdDemo.Models.Crop", b =>
                {
                    b.Navigation("Advertisements");
                });
#pragma warning restore 612, 618
        }
    }
}
