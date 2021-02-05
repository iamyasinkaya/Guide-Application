using Microsoft.EntityFrameworkCore.Migrations;

namespace GuideApp.Web.Migrations
{
    public partial class NewContactInfoIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactInformation_ContactId",
                table: "ContactInformation");

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_ContactId",
                table: "ContactInformation",
                column: "ContactId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContactInformation_ContactId",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_ContactId",
                table: "ContactInformation",
                column: "ContactId");
        }
    }
}
