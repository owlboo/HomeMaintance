using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMaintance.Data.Migrations
{
    public partial class addAvatarHumanResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "HumanResources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "HumanResources");
        }
    }
}
