using Microsoft.EntityFrameworkCore.Migrations;

namespace Ace_Auto_Dealers_WebApi.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "purchase",
                table: "Customers",
                newName: "Purchase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Purchase",
                table: "Customers",
                newName: "purchase");
        }
    }
}
