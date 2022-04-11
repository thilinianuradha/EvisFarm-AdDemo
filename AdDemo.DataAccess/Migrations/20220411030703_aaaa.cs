using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Advertisements");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "StartingDate",
                table: "Advertisements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartingDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartingDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartingDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartingDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1093), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1095), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1097), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(820), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(838), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(840), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(842), new DateTime(2022, 4, 11, 8, 37, 2, 663, DateTimeKind.Local).AddTicks(841) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "StartingDate",
                table: "Advertisements");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Maize Cultivation");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Cocoa Cultivation");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Carrot Cultivation");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Cabbage Cultivation");

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
    }
}
