using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class mmmmmmmllkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6943), new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6946), new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 2, 26, 11, 49, 13, 409, DateTimeKind.Local).AddTicks(6947) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3737), new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3755), new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 2, 26, 11, 44, 31, 353, DateTimeKind.Local).AddTicks(3756) });
        }
    }
}
