using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class mmmmmmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pending_Request_Advertisements_AdvertisementId",
                table: "Pending_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Pending_Request_Vendors_Posted_By",
                table: "Pending_Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pending_Request",
                table: "Pending_Request");

            migrationBuilder.RenameTable(
                name: "Pending_Request",
                newName: "PendingRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Pending_Request_Posted_By",
                table: "PendingRequests",
                newName: "IX_PendingRequests_Posted_By");

            migrationBuilder.RenameIndex(
                name: "IX_Pending_Request_AdvertisementId",
                table: "PendingRequests",
                newName: "IX_PendingRequests_AdvertisementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingRequests",
                table: "PendingRequests",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedOn", "District", "IsDeleted", "LastUpdatedOn", "Name", "UserType" },
                values: new object[] { 1, new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6802), "Vavniya", false, new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6800), "Samadhi", "Farmer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedOn", "District", "IsDeleted", "LastUpdatedOn", "Name", "UserType" },
                values: new object[] { 2, new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6807), "Vavniya", false, new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6806), "Samadhi", "Farmer" });

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Advertisements_AdvertisementId",
                table: "PendingRequests",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Vendors_Posted_By",
                table: "PendingRequests",
                column: "Posted_By",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Advertisements_AdvertisementId",
                table: "PendingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Vendors_Posted_By",
                table: "PendingRequests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingRequests",
                table: "PendingRequests");

            migrationBuilder.RenameTable(
                name: "PendingRequests",
                newName: "Pending_Request");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_Posted_By",
                table: "Pending_Request",
                newName: "IX_Pending_Request_Posted_By");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_AdvertisementId",
                table: "Pending_Request",
                newName: "IX_Pending_Request_AdvertisementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pending_Request",
                table: "Pending_Request",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pending_Request_Advertisements_AdvertisementId",
                table: "Pending_Request",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pending_Request_Vendors_Posted_By",
                table: "Pending_Request",
                column: "Posted_By",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
