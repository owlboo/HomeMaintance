using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMaintance.Data.Migrations
{
    public partial class updateHumanResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HumanResources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "HumanResources");
        }
    }
}
