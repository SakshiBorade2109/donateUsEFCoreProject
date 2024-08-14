using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonateUsEfCore2.Migrations
{
    /// <inheritdoc />
    public partial class updation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Donationid",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Donationid",
                table: "Users",
                column: "Donationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Donations_Donationid",
                table: "Users",
                column: "Donationid",
                principalTable: "Donations",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Donations_Donationid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Donationid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Donationid",
                table: "Users");
        }
    }
}
