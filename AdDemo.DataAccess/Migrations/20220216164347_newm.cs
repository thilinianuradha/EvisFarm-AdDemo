using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class newm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Advertisements_AdvertisementId",
                table: "PendingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Vendors_PostedBy",
                table: "PendingRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingRequests",
                table: "PendingRequests");

            migrationBuilder.RenameTable(
                name: "PendingRequests",
                newName: "Pending_Request");

            migrationBuilder.RenameColumn(
                name: "PostedBy",
                table: "Pending_Request",
                newName: "Posted_By");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_PostedBy",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pending_Request_Advertisements_AdvertisementId",
                table: "Pending_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Pending_Request_Vendors_Posted_By",
                table: "Pending_Request");

            migrationBuilder.DropTable(
                name: "AcceptedRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pending_Request",
                table: "Pending_Request");

            migrationBuilder.RenameTable(
                name: "Pending_Request",
                newName: "PendingRequests");

            migrationBuilder.RenameColumn(
                name: "Posted_By",
                table: "PendingRequests",
                newName: "PostedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Pending_Request_Posted_By",
                table: "PendingRequests",
                newName: "IX_PendingRequests_PostedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Pending_Request_AdvertisementId",
                table: "PendingRequests",
                newName: "IX_PendingRequests_AdvertisementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingRequests",
                table: "PendingRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Advertisements_AdvertisementId",
                table: "PendingRequests",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Vendors_PostedBy",
                table: "PendingRequests",
                column: "PostedBy",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
