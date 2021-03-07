using Microsoft.EntityFrameworkCore.Migrations;

namespace Ace_Auto_Dealers_WebApi.Migrations
{
    public partial class AddSalesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SalesRepresentativeId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesRepresentativeName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalesRepresentativeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SalesRepresentativeName",
                table: "Customers");
        }
    }
}
