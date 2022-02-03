using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class vendors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Crops_CropId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CropId",
                table: "Advertisements");

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoofPendingRequests = table.Column<int>(type: "int", nullable: false),
                    NoofInprogressAds = table.Column<int>(type: "int", nullable: false),
                    NoofClosedAds = table.Column<int>(type: "int", nullable: false),
                    CropId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "CropId", "FullName", "Location", "NoofClosedAds", "NoofInprogressAds", "NoofPendingRequests" },
                values: new object[,]
                {
                    { 1, 0, "Thilini Anuradha", "Anuradhapura", 0, 0, 1 },
                    { 2, 0, "Piyumi Thathsarani", "Mathara", 3, 1, 4 },
                    { 3, 0, "Thanuja Mahendran", "Jaffna", 3, 0, 5 },
                    { 4, 0, "Umesha Nirmani", "Awissawella", 0, 3, 1 },
                    { 5, 0, "Nirmani Herath", "Monaragala", 0, 5, 4 },
                    { 6, 0, "Thilini Erandi", "Galle", 3, 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Advertisements");

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
