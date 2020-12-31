using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class CartDetailsTable_DeleteBehaviorCascadeSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID",
                table: "CartDetailTable");

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartDetailTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID",
                table: "CartDetailTable",
                column: "CartID",
                principalTable: "CartTable",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID",
                table: "CartDetailTable");

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartDetailTable",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID",
                table: "CartDetailTable",
                column: "CartID",
                principalTable: "CartTable",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
