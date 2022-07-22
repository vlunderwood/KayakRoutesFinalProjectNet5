using Microsoft.EntityFrameworkCore.Migrations;

namespace KayakRoutesFinalProject.Migrations
{
    public partial class Route : Migration
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
                    StartPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StopPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miles = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Date", "Level", "Location", "Miles", "Name", "Rating", "StartPoint", "StopPoint", "Type" },
                values: new object[] { 1, "04/05/2022", "Intermediate", "Skunk River", 2.0, "Val", 5, "Anderson Access", "Sleepy Hollow Access", "River" });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Date", "Level", "Location", "Miles", "Name", "Rating", "StartPoint", "StopPoint", "Type" },
                values: new object[] { 2, "06/23/2022", "Advanced", "Raccoon River", 4.0, "Noah", 5, "City Park Access", "White Horse Access", "River" });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "Date", "Level", "Location", "Miles", "Name", "Rating", "StartPoint", "StopPoint", "Type" },
                values: new object[] { 3, "05/10/2022", "Intermediate", "Des Moines River", 3.0, "Alexander", 5, "Skillet Creek Access", "North Fraser Access", "River" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
