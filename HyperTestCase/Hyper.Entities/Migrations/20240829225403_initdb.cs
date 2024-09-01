using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hyper.Entities.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadlightsOn = table.Column<bool>(type: "bit", nullable: false),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Color" },
                values: new object[,]
                {
                    { 1, "red" },
                    { 2, "blue" },
                    { 3, "white" },
                    { 4, "red" },
                    { 5, "black" },
                    { 6, "white" },
                    { 7, "blue" },
                    { 8, "black" },
                    { 9, "cyan" },
                    { 10, "white" },
                    { 11, "cyan" },
                    { 12, "blue" },
                    { 13, "black" },
                    { 14, "red" },
                    { 15, "white" },
                    { 16, "red" }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Color" },
                values: new object[,]
                {
                    { 1, "red" },
                    { 2, "yellow" },
                    { 3, "white" },
                    { 4, "red" },
                    { 5, "black" },
                    { 6, "white" },
                    { 7, "blue" },
                    { 8, "yellow" },
                    { 9, "cyan" },
                    { 10, "white" },
                    { 11, "cyan" },
                    { 12, "blue" },
                    { 13, "black" },
                    { 14, "red" },
                    { 15, "white" },
                    { 16, "yellow" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "HeadlightsOn", "Wheels" },
                values: new object[,]
                {
                    { 1, "red", true, 4 },
                    { 2, "black", false, 4 },
                    { 3, "white", false, 4 },
                    { 4, "blue", true, 4 },
                    { 5, "yellow", true, 4 },
                    { 6, "yellow", false, 4 },
                    { 7, "blue", false, 4 },
                    { 8, "white", false, 4 },
                    { 9, "black", true, 4 },
                    { 10, "red", false, 4 },
                    { 11, "black", true, 4 },
                    { 12, "white", true, 4 },
                    { 13, "blue", false, 4 },
                    { 14, "yellow", true, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
