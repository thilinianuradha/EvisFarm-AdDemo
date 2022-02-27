using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class hiiI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9582), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9584), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9459), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9471), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9472), new DateTime(2022, 2, 27, 22, 59, 57, 142, DateTimeKind.Local).AddTicks(9472) });
        }
    }
}
