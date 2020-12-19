using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class DeliveryInfoTableNavigationPropertyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_UserIDId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryInfoTable_UserIDId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropColumn(
                name: "UserIDId",
                table: "DeliveryInfoTable");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "DeliveryInfoTable",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryInfoTable_UserId",
                table: "DeliveryInfoTable",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_UserId",
                table: "DeliveryInfoTable",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_UserId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryInfoTable_UserId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DeliveryInfoTable");

            migrationBuilder.AddColumn<string>(
                name: "UserIDId",
                table: "DeliveryInfoTable",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryInfoTable_UserIDId",
                table: "DeliveryInfoTable",
                column: "UserIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_UserIDId",
                table: "DeliveryInfoTable",
                column: "UserIDId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
