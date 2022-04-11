using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class bbbbL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptedOn",
                table: "PendingRequests");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "PendingRequests");

            migrationBuilder.DropColumn(
                name: "No_of_requests",
                table: "PendingRequests");

            migrationBuilder.DropColumn(
                name: "PostedOn",
                table: "PendingRequests");

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8139), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8141), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8142), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8018), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8030), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8031), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8033), new DateTime(2022, 3, 23, 17, 5, 54, 651, DateTimeKind.Local).AddTicks(8032) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptedOn",
                table: "PendingRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "PendingRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "No_of_requests",
                table: "PendingRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedOn",
                table: "PendingRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
