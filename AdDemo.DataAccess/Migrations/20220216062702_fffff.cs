using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class fffff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pending_request_Advertisements_AdvertisementId",
                table: "Pending_request");

            migrationBuilder.DropForeignKey(
                name: "FK_Pending_request_Vendors_VendorId",
                table: "Pending_request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pending_request",
                table: "Pending_request");

            migrationBuilder.DropIndex(
                name: "IX_Pending_request_VendorId",
                table: "Pending_request");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "Pending_request");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Pending_request");

            migrationBuilder.RenameTable(
                name: "Pending_request",
                newName: "PendingRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Pending_request_AdvertisementId",
                table: "PendingRequests",
                newName: "IX_PendingRequests_AdvertisementId");

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "PendingRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingRequests",
                table: "PendingRequests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PendingRequests_PostedBy",
                table: "PendingRequests",
                column: "PostedBy");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_PendingRequests_PostedBy",
                table: "PendingRequests");

            migrationBuilder.RenameTable(
                name: "PendingRequests",
                newName: "Pending_request");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_AdvertisementId",
                table: "Pending_request",
                newName: "IX_Pending_request_AdvertisementId");

            migrationBuilder.AlterColumn<string>(
                name: "PostedBy",
                table: "Pending_request",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "Pending_request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Pending_request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pending_request",
                table: "Pending_request",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pending_request_VendorId",
                table: "Pending_request",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pending_request_Advertisements_AdvertisementId",
                table: "Pending_request",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pending_request_Vendors_VendorId",
                table: "Pending_request",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
