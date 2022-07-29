using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addingIdentityFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CustomerLists_BankId",
                table: "CustomerLists");

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLists_BankId",
                table: "CustomerLists",
                column: "BankId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CustomerLists_BankId",
                table: "CustomerLists");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLists_BankId",
                table: "CustomerLists",
                column: "BankId");
        }
    }
}
