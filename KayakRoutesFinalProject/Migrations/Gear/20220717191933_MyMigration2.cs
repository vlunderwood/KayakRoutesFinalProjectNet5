using Microsoft.EntityFrameworkCore.Migrations;

namespace KayakRoutesFinalProject.Migrations.Gear
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    GearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gears", x => x.GearId);
                });

            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "GearId", "Condition", "Contact", "Description", "Phone", "Price" },
                values: new object[] { 1, "used", "Valerie", "1 life jacket, size medium", "515-555-2462", "$10.00" });

            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "GearId", "Condition", "Contact", "Description", "Phone", "Price" },
                values: new object[] { 2, "used", "Tom", "2 kayaks paddles", "641-555-8954", "$50.00 or OBO also open to trade" });

            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "GearId", "Condition", "Contact", "Description", "Phone", "Price" },
                values: new object[] { 3, "used", "Leslie", "Pelican sit in kayak", "515-555-9034", "$120.00, open to trade" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gears");
        }
    }
}
