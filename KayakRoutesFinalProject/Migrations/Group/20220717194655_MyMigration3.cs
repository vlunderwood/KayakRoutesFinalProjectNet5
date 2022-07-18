using Microsoft.EntityFrameworkCore.Migrations;

namespace KayakRoutesFinalProject.Migrations.Group
{
    public partial class MyMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StopPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Contact", "Date", "Description", "Location", "Phone", "StartPoint", "StopPoint", "Time" },
                values: new object[] { 1, "Noah", "07/23/2022", "Bring all your own gear and snacks.", "Red Rock Lake", "515-555-5589", "Roberts Creak", "Roberts Creak", "10 AM" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Contact", "Date", "Description", "Location", "Phone", "StartPoint", "StopPoint", "Time" },
                values: new object[] { 2, "Alex", "07/28/2022", "Bring all your own gear, I have a couple extra life jackets.", "Red Haw Lake loop", "641-555-2532", "boat ramp", "boat ramp", "9 AM" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Contact", "Date", "Description", "Location", "Phone", "StartPoint", "StopPoint", "Time" },
                values: new object[] { 3, "Leslie", "08/10/2022", "Bring your own gear, call KayaksExpress @ 515-555-7756 for rentals! ", "Raccoon River", "515-555-9034", "Walnut Woods state Park", "Water Works Park", "12 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
