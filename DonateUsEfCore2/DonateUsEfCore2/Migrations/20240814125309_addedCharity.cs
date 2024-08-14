using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonateUsEfCore2.Migrations
{
    /// <inheritdoc />
    public partial class addedCharity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "charityId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "charityId",
                table: "Donations");
        }
    }
}
