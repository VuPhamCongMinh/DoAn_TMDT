using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class DeliveryInfoTableNavigationPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_ApplicationUserId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryInfoTable_ApplicationUserId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "DeliveryInfoTable");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "DeliveryInfoTable");

            migrationBuilder.AddColumn<string>(
                name: "UserIDId",
                table: "DeliveryInfoTable",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ApplicationUserId",
                table: "DeliveryInfoTable",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "DeliveryInfoTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryInfoTable_ApplicationUserId",
                table: "DeliveryInfoTable",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryInfoTable_AspNetUsers_ApplicationUserId",
                table: "DeliveryInfoTable",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
