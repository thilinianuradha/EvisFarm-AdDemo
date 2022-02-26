using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class mmmmmmmll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Buyers",
                newName: "User_Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Buyers",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6802), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedOn", "LastUpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 2, 26, 9, 8, 31, 511, DateTimeKind.Local).AddTicks(6806) });
        }
    }
}
