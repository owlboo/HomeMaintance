using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMaintance.Data.Migrations
{
    public partial class updateTopHotService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeCount",
                table: "Services");

            migrationBuilder.AddColumn<DateTime>(
                name: "TopHot",
                table: "Services",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopHot",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "LikeCount",
                table: "Services",
                nullable: false,
                defaultValue: 0);
        }
    }
}
