using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class CartTableIsDisplayPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisplay",
                table: "CartTable",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisplay",
                table: "CartTable");
        }
    }
}
