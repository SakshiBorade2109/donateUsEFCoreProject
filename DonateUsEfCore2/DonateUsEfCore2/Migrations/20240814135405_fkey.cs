using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonateUsEfCore2.Migrations
{
    /// <inheritdoc />
    public partial class fkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charities_Donations_Donationid",
                table: "Charities");

            migrationBuilder.DropIndex(
                name: "IX_Charities_Donationid",
                table: "Charities");

            migrationBuilder.DropColumn(
                name: "Donationid",
                table: "Charities");

            migrationBuilder.AddColumn<int>(
                name: "DonationAreaid",
                table: "Donations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_charityId",
                table: "Donations",
                column: "charityId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonationAreaid",
                table: "Donations",
                column: "DonationAreaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Charities_charityId",
                table: "Donations",
                column: "charityId",
                principalTable: "Charities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_DonationsArea_DonationAreaid",
                table: "Donations",
                column: "DonationAreaid",
                principalTable: "DonationsArea",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Charities_charityId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_DonationsArea_DonationAreaid",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_charityId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonationAreaid",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationAreaid",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "Donationid",
                table: "Charities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Charities_Donationid",
                table: "Charities",
                column: "Donationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Charities_Donations_Donationid",
                table: "Charities",
                column: "Donationid",
                principalTable: "Donations",
                principalColumn: "id");
        }
    }
}
