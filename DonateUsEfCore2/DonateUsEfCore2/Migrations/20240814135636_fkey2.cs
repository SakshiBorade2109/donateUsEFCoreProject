using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonateUsEfCore2.Migrations
{
    /// <inheritdoc />
    public partial class fkey2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_DonationsArea_DonationAreaid",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "DonationAreaid",
                table: "Donations",
                newName: "donationAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_DonationAreaid",
                table: "Donations",
                newName: "IX_Donations_donationAreaId");

            migrationBuilder.AlterColumn<int>(
                name: "donationAreaId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_DonationsArea_donationAreaId",
                table: "Donations",
                column: "donationAreaId",
                principalTable: "DonationsArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_DonationsArea_donationAreaId",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "donationAreaId",
                table: "Donations",
                newName: "DonationAreaid");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_donationAreaId",
                table: "Donations",
                newName: "IX_Donations_DonationAreaid");

            migrationBuilder.AlterColumn<int>(
                name: "DonationAreaid",
                table: "Donations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_DonationsArea_DonationAreaid",
                table: "Donations",
                column: "DonationAreaid",
                principalTable: "DonationsArea",
                principalColumn: "id");
        }
    }
}
