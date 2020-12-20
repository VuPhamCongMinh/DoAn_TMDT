using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnTMDT.Migrations
{
    public partial class DeliveryInfoTableAddressValueConstraintAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateCheckConstraint(
                name: "CK_DeliveryInfoTable_AddressValueColumn",
                table: "DeliveryInfoTable",
                sql: "[AddressValue] >= 1 AND [AddressValue] <=2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_DeliveryInfoTable_AddressValueColumn",
                table: "DeliveryInfoTable");
        }
    }
}
