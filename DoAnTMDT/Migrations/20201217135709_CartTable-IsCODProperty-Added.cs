using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class CartTableIsCODPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCOD",
                table: "CartTable",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCOD",
                table: "CartTable");
        }
    }
}
