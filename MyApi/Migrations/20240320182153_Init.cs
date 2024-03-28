using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wieses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    isValid = table.Column<bool>(type: "INTEGER", nullable: false),
                    requestDate = table.Column<string>(type: "TEXT", nullable: true),
                    userError = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wieses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Wieses",
                columns: new[] { "Id", "address", "isValid", "name", "requestDate", "userError" },
                values: new object[,]
                {
                    { 1, "Polna 2", true, "Biedronka", null, null },
                    { 2, "Polna 3", true, "Lidl", null, null },
                    { 3, "Polna 4", true, "OBI", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wieses");
        }
    }
}
