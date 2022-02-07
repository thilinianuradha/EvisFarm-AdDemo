using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class ccccccccccccccccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaofCultivation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lastmodifieddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    AcceptedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcceptedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modify_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    NoOfAdvertisements = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofPendingRequests = table.Column<int>(type: "int", nullable: false),
                    NoofInprogressAds = table.Column<int>(type: "int", nullable: false),
                    NoofClosedAds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AcceptedBy", "AcceptedOn", "AreaofCultivation", "CreatedBy", "CreatedOn", "DeletedOn", "Description", "EstimatedPrice", "IsAccepted", "IsAvailable", "IsDeleted", "Lastmodifieddate", "Location" },
                values: new object[,]
                {
                    { 1, "", null, "50Acres", "Sam", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maize Cultivation", "Rs. 25,000.00", false, true, false, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anuradhapura" },
                    { 2, "", null, "20Acres", "Peter", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cocoa Cultivation", "Rs. 75,000.00", false, true, false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombo" },
                    { 3, "", null, "100Acres", "Michael", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carrot Cultivation", "Rs. 100,000.00", false, true, false, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandy" },
                    { 4, "", null, "40Acres", "Mary", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cabbage Cultivation", "Rs. 10,000.00", false, true, false, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Badulla" }
                });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "DeletedBy", "DeletedOn", "Email", "FullName", "IsActive", "IsDeleted", "IsModified", "JoinedOn", "LastModifiedOn", "Location", "Modify_remarks", "UserId" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aaa@gmail.com", "Michael", true, false, false, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anuradhapura", "", 1 },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bbb@gmail.com", "Felton", true, false, false, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vavniya", "", 2 },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ccc@gmail.com", "Harry", true, false, false, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombo", "", 3 },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddd@gmail.com", "Allen", true, false, false, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Badulla", "", 4 },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eee@gmail.com", "Helen", true, false, false, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilaw", "", 5 },
                    { 6, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fff@gmail.com", "Ron", true, false, false, new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matara", "", 6 }
                });

            migrationBuilder.InsertData(
                table: "Crops",
                columns: new[] { "Id", "CropName", "CropType", "IsAvailable", "NoOfAdvertisements" },
                values: new object[,]
                {
                    { 1, "Carrot", "Vegetables", true, 1 },
                    { 2, "Beans", "Vegetables", true, 1 },
                    { 3, "Pears", "Fruits", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "FullName", "Location", "NoofClosedAds", "NoofInprogressAds", "NoofPendingRequests" },
                values: new object[,]
                {
                    { 1, "Thilini Anuradha", "Anuradhapura", 0, 0, 1 },
                    { 2, "Piyumi Thathsarani", "Mathara", 3, 1, 4 },
                    { 3, "Thanuja Mahendran", "Jaffna", 3, 0, 5 },
                    { 4, "Umesha Nirmani", "Awissawella", 0, 3, 1 },
                    { 5, "Nirmani Herath", "Monaragala", 0, 5, 4 },
                    { 6, "Thilini Erandi", "Galle", 3, 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
