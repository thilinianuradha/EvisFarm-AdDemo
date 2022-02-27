using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class hii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcceptedRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementId = table.Column<int>(type: "int", nullable: false),
                    Postedby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AcceptedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedRequests", x => x.Id);
                });

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
                    User_Id = table.Column<int>(type: "int", nullable: false),
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
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "PendingRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementId = table.Column<int>(type: "int", nullable: false),
                    Posted_By = table.Column<int>(type: "int", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_of_requests = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    AcceptedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PendingRequests_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingRequests_Vendors_Posted_By",
                        column: x => x.Posted_By,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "DeletedBy", "DeletedOn", "Email", "FullName", "IsActive", "IsDeleted", "IsModified", "JoinedOn", "LastModifiedOn", "Location", "Modify_remarks", "User_Id" },
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
                    { 3, "Pears", "Fruits", true, 1 },
                    { 4, "Banana", "Fruits", true, 5 }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "CreatedDate", "DeletedOn", "District", "IsDeleted", "LastUpdatedOn", "Name", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9582), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9584), "Vavniya", false, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9583), "Samadhi", "Farmer" },
                    { 2, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9586), "Vavniya", false, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9586), "Samadhi", "Farmer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedOn", "DeletedRemarks", "IsAvailable", "LastUpdatedOn", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "M.N. nisha", new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9459), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9470), "#####", true, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9469), "n", "nisha" },
                    { 2, "M.N. Zanda", new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9471), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9472), "######", true, new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9472), "m", "Zanda" }
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

            migrationBuilder.CreateIndex(
                name: "IX_PendingRequests_AdvertisementId",
                table: "PendingRequests",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingRequests_Posted_By",
                table: "PendingRequests",
                column: "Posted_By");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptedRequests");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropTable(
                name: "PendingRequests");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
