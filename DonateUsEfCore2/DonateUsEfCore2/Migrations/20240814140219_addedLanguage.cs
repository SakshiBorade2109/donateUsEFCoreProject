using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DonateUsEfCore2.Migrations
{
    /// <inheritdoc />
    public partial class addedLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "id", "language" },
                values: new object[,]
                {
                    { 1278, "en" },
                    { 78456, "hindi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 78456);
        }
    }
}
