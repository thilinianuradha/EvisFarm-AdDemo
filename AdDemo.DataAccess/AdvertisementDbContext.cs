﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AdDemo.DataAccess
{
    public class AdvertisementDbContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb;  Database = EvisFarmDb; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crop>().HasData(new Crop[]
            {new Crop
            {
                Id = 01,
               CropType = "Vegetables",
               CropName ="Carrot",
               IsAvailable = true,
               NoOfAdvertisements = 4
            },
            new Crop
            {
                Id = 02,
               CropType = "Vegetables",
               CropName ="Beans",
               IsAvailable = true,
               NoOfAdvertisements = 1
            },
            new Crop
            {
                Id = 03,
               CropType = "Fruits",
               CropName ="Pears",
               IsAvailable = true,
               NoOfAdvertisements = 10
            }
            });

            modelBuilder.Entity<Advertisement>().HasData(new Advertisement[]
            {new Advertisement
            {
                Id = 01,
                CropId = 1,
                Location = "Anuradhapura",
                Description = "Maize Cultivation",
                EstimatedPrice = "Rs. 25,000.00",
                AreaofCultivation = "50Acres",
                CreatedBy = "Sam",
                CreatedOn = new DateTime(2022,01,05),
                Lastmodifieddate = new DateTime(2022,01,22),
                IsAvailable = true,
                IsAccepted = false,
                AcceptedOn = null,
                AcceptedBy = "",
                IsDeleted = false,
                DeletedOn = null

            },
            new Advertisement
            {
                Id = 02,
                CropId = 2,
                Location = "Colombo",
                Description = "Cocoa Cultivation",
                EstimatedPrice = "Rs. 75,000.00",
                AreaofCultivation = "20Acres",
                CreatedBy = "Peter",
                CreatedOn = new DateTime(2022, 02, 05),
                Lastmodifieddate = new DateTime(2022, 02, 22),
                IsAvailable = true,
                IsAccepted = false,
                AcceptedOn = null,
                AcceptedBy = "",
                IsDeleted = false,
                DeletedOn = null

            },
            new Advertisement
            {
                Id = 03,
                CropId = 1,
                Location = "Kandy",
                Description = "Carrot Cultivation",
                EstimatedPrice = "Rs. 100,000.00",
                AreaofCultivation = "100Acres",
                CreatedBy = "Michael",
                CreatedOn = new DateTime(2022, 01, 12),
                Lastmodifieddate = new DateTime(2022, 01, 29),
                IsAvailable = true,
                IsAccepted = false,
                AcceptedOn = null,
                AcceptedBy = "",
                IsDeleted = false,
                DeletedOn = null

            },
             new Advertisement
            {
                Id = 04,
                CropId = 4,
                Location = "Badulla",
                Description = "Cabbage Cultivation",
                EstimatedPrice = "Rs. 10,000.00",
                AreaofCultivation = "40Acres",
                CreatedBy = "Mary",
                CreatedOn = new DateTime(2022, 01, 24),
                Lastmodifieddate = new DateTime(2022, 01, 31),
                IsAvailable = true,
                IsAccepted = false,
                AcceptedOn = null,
                AcceptedBy = "",
                IsDeleted = false,
                DeletedOn = null

            }
            });
            modelBuilder.Entity<Vendor>().HasData(new Vendor[]
        {new Vendor
            {
               Id = 01,
               FullName = "Thilini Anuradha",
               Location ="Anuradhapura",
               NoofPendingRequests = 1,
               NoofInprogressAds = 0,
               NoofClosedAds = 0,
            },
            new Vendor
            {
               Id = 02,
               FullName = "Piyumi Thathsarani",
               Location ="Mathara",
               NoofPendingRequests = 4,
               NoofInprogressAds = 1,
               NoofClosedAds = 3,
            },
            new Vendor
            {
               Id = 03,
               FullName = "Thanuja Mahendran",
               Location ="Jaffna",
               NoofPendingRequests = 5,
               NoofInprogressAds = 0,
               NoofClosedAds = 3,
            },
            new Vendor
            {
               Id = 04,
               FullName = "Umesha Nirmani",
               Location ="Awissawella",
               NoofPendingRequests = 1,
               NoofInprogressAds = 3,
               NoofClosedAds = 0,
            },
            new Vendor
            {
               Id = 05,
               FullName = "Nirmani Herath",
               Location ="Monaragala",
               NoofPendingRequests = 4,
               NoofInprogressAds = 5,
               NoofClosedAds = 0,
            },
            new Vendor
            {
               Id = 06,
               FullName = "Thilini Erandi",
               Location ="Galle",
               NoofPendingRequests = 1,
               NoofInprogressAds = 4,
               NoofClosedAds = 3,
            }
        });


        }
    }
}
