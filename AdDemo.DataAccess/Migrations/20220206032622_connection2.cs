using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdDemo.DataAccess.Migrations
{
    public partial class connection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendorID",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_VendorID",
                table: "Advertisements",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Vendors_VendorID",
                table: "Advertisements",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Vendors_VendorID",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_VendorID",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "VendorID",
                table: "Advertisements");
        }
    }
}
