using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class CartTablePrimaryKeyChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID",
                table: "CartDetailTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartTable",
                table: "CartTable");

            migrationBuilder.DropIndex(
                name: "IX_CartDetailTable_CartID",
                table: "CartDetailTable");

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartTable",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CartTable",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartDetailTable",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartID1",
                table: "CartDetailTable",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartTable",
                table: "CartTable",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetailTable_CartID1",
                table: "CartDetailTable",
                column: "CartID1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID1",
                table: "CartDetailTable",
                column: "CartID1",
                principalTable: "CartTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetailTable_CartTable_CartID1",
                table: "CartDetailTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartTable",
                table: "CartTable");

            migrationBuilder.DropIndex(
                name: "IX_CartDetailTable_CartID1",
                table: "CartDetailTable");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CartTable");

            migrationBuilder.DropColumn(
                name: "CartID1",
                table: "CartDetailTable");

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartTable",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CartID",
                table: "CartDetailTable",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartTable",
                table: "CartTable",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetailTable_CartID",
                table: "CartDetailTable",
                column: "CartID");

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
