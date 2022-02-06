using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class connection1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
