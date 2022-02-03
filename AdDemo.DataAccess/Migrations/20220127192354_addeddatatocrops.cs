using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class addeddatatocrops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CropId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Crops",
                columns: new[] { "Id", "CropName", "CropType", "IsAvailable", "NoOfAdvertisements" },
                values: new object[] { 1, "Carrot", "Vegetables", true, 4 });

            migrationBuilder.InsertData(
                table: "Crops",
                columns: new[] { "Id", "CropName", "CropType", "IsAvailable", "NoOfAdvertisements" },
                values: new object[] { 2, "Beans", "Vegetables", true, 1 });

            migrationBuilder.InsertData(
                table: "Crops",
                columns: new[] { "Id", "CropName", "CropType", "IsAvailable", "NoOfAdvertisements" },
                values: new object[] { 3, "Pears", "Fruits", true, 10 });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CropId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CropId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CropId",
                value: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Crops_CropId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CropId",
                table: "Advertisements");

            migrationBuilder.DeleteData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CropId",
                table: "Advertisements");
        }
    }
}
