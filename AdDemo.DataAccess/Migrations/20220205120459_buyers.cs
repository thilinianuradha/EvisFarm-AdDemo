using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class buyers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Vendors_VendorId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_VendorId",
                table: "Advertisements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_VendorId",
                table: "Advertisements",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Vendors_VendorId",
                table: "Advertisements",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
