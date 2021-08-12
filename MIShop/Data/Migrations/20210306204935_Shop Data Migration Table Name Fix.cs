using Microsoft.EntityFrameworkCore.Migrations;

namespace MIShop.Data.Migrations
{
    public partial class ShopDataMigrationTableNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument");

            migrationBuilder.RenameTable(
                name: "Instrument",
                newName: "Instruments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments");

            migrationBuilder.RenameTable(
                name: "Instruments",
                newName: "Instrument");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument",
                column: "Id");
        }
    }
}
