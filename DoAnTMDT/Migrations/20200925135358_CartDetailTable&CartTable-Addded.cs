using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class CartDetailTableCartTableAddded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartTable",
                columns: table => new
                {
                    CartID = table.Column<string>(nullable: false),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTable", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "CartDetailTable",
                columns: table => new
                {
                    CartDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetailTable", x => x.CartDetailID);
                    table.ForeignKey(
                        name: "FK_CartDetailTable_CartTable_CartID",
                        column: x => x.CartID,
                        principalTable: "CartTable",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartDetailTable_ProductTable_ProductID",
                        column: x => x.ProductID,
                        principalTable: "ProductTable",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetailTable_CartID",
                table: "CartDetailTable",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetailTable_ProductID",
                table: "CartDetailTable",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetailTable");

            migrationBuilder.DropTable(
                name: "CartTable");
        }
    }
}
