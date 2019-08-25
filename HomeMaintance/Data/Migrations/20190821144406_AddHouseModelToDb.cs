using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMaintance.Data.Migrations
{
    public partial class AddHouseModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HouseModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseModelName = table.Column<string>(nullable: true),
                    ImageThumbnail = table.Column<string>(nullable: true),
                    HouseModelCategoryId = table.Column<int>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    TopHot = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseModels_HouseModelCategories_HouseModelCategoryId",
                        column: x => x.HouseModelCategoryId,
                        principalTable: "HouseModelCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseModelImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseModelId = table.Column<long>(nullable: false),
                    HouseModelsId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseModelImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseModelImages_HouseModels_HouseModelsId",
                        column: x => x.HouseModelsId,
                        principalTable: "HouseModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseModelImages_HouseModelsId",
                table: "HouseModelImages",
                column: "HouseModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseModels_HouseModelCategoryId",
                table: "HouseModels",
                column: "HouseModelCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseModelImages");

            migrationBuilder.DropTable(
                name: "HouseModels");
        }
    }
}
