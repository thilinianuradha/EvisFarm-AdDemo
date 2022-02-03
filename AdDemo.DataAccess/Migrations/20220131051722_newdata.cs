using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Advertisements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AcceptedBy", "AcceptedOn", "AreaofCultivation", "CreatedBy", "CreatedOn", "CropId", "DeletedOn", "Description", "EstimatedPrice", "IsAccepted", "IsAvailable", "IsDeleted", "Lastmodifieddate", "Location" },
                values: new object[] { 4, "", null, "40Acres", "Mary", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Cabbage Cultivation", "Rs. 10,000.00", false, true, false, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Badulla" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
