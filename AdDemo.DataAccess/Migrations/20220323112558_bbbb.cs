using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class bbbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Vendors_Posted_By",
                table: "PendingRequests");

            migrationBuilder.RenameColumn(
                name: "Posted_By",
                table: "PendingRequests",
                newName: "VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_Posted_By",
                table: "PendingRequests",
                newName: "IX_PendingRequests_VendorId");

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4278), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4065), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4082), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4085), new DateTime(2022, 3, 23, 16, 55, 58, 279, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Vendors_VendorId",
                table: "PendingRequests",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingRequests_Vendors_VendorId",
                table: "PendingRequests");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "PendingRequests",
                newName: "Posted_By");

            migrationBuilder.RenameIndex(
                name: "IX_PendingRequests_VendorId",
                table: "PendingRequests",
                newName: "IX_PendingRequests_Posted_By");

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8102), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8104), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7928), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7941), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7942), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7943), new DateTime(2022, 2, 27, 23, 2, 4, 22, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.AddForeignKey(
                name: "FK_PendingRequests_Vendors_Posted_By",
                table: "PendingRequests",
                column: "Posted_By",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
