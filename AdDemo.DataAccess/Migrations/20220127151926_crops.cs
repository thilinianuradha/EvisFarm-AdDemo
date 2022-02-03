using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class crops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    NoOfAdvertisements = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CropId",
                table: "Advertisements");
        }
    }
}
