using Microsoft.EntityFrameworkCore.Migrations;

namespace MIShop.Data.Migrations
{
    public partial class ShopDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrumMeshMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrumType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FluteType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfStrings = table.Column<int>(type: "int", nullable: true),
                    GuitarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViolinType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BowMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrument");
        }
    }
}
