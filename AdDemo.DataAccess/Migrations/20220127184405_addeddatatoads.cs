using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class addeddatatoads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Crops_CropId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CropId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CropId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Advertisements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Advertisements",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcceptedOn",
                table: "Advertisements",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "AcceptedBy",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AcceptedBy", "AcceptedOn", "AreaofCultivation", "CreatedBy", "CreatedOn", "DeletedOn", "Description", "EstimatedPrice", "IsAccepted", "IsAvailable", "IsDeleted", "Lastmodifieddate", "Location" },
                values: new object[] { 1, "", null, "50Acres", "Sam", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maize Cultivation", "Rs. 25,000.00", false, true, false, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anuradhapura" });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AcceptedBy", "AcceptedOn", "AreaofCultivation", "CreatedBy", "CreatedOn", "DeletedOn", "Description", "EstimatedPrice", "IsAccepted", "IsAvailable", "IsDeleted", "Lastmodifieddate", "Location" },
                values: new object[] { 2, "", null, "20Acres", "Peter", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cocoa Cultivation", "Rs. 75,000.00", false, true, false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombo" });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AcceptedBy", "AcceptedOn", "AreaofCultivation", "CreatedBy", "CreatedOn", "DeletedOn", "Description", "EstimatedPrice", "IsAccepted", "IsAvailable", "IsDeleted", "Lastmodifieddate", "Location" },
                values: new object[] { 3, "", null, "100Acres", "Michael", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carrot Cultivation", "Rs. 100,000.00", false, true, false, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kandy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AcceptedBy",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Advertisements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Advertisements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcceptedOn",
                table: "Advertisements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CropId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CropId",
                table: "Advertisements",
                column: "CropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Crops_CropId",
                table: "Advertisements",
                column: "CropId",
                principalTable: "Crops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
