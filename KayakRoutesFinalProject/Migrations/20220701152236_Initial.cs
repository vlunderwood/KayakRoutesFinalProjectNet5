using Microsoft.EntityFrameworkCore.Migrations;

namespace KayakRoutesFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Level", "Location", "Name", "Rating" },
                values: new object[] { 1, "High", "Skunk River", "Val", 5 });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Level", "Location", "Name", "Rating" },
                values: new object[] { 2, "Low", "Chariton River", "Noah", 5 });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Level", "Location", "Name", "Rating" },
                values: new object[] { 3, "High", "Des Moines River", "Alexander", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
