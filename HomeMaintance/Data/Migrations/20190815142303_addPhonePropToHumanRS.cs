using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMaintance.Data.Migrations
{
    public partial class addPhonePropToHumanRS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "HumanResources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "HumanResources");
        }
    }
}
