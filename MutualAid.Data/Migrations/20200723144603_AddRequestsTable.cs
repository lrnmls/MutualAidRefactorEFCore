using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAid.Data.Migrations
{
    public partial class AddRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false, defaultValue: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ToiletPaper = table.Column<string>(nullable: true),
                    PaperTowels = table.Column<string>(nullable: true),
                    HandSoap = table.Column<string>(nullable: true),
                    Shampoo = table.Column<string>(nullable: true),
                    Conditioner = table.Column<string>(nullable: true),
                    Toothpaste = table.Column<string>(nullable: true),
                    Disinfectant = table.Column<string>(nullable: true),
                    Dairy = table.Column<string>(nullable: true),
                    Bread = table.Column<string>(nullable: true),
                    Produce = table.Column<string>(nullable: true),
                    CannedFood = table.Column<string>(nullable: true),
                    Meat = table.Column<string>(nullable: true),
                    Seafood = table.Column<string>(nullable: true),
                    Cereal = table.Column<string>(nullable: true),
                    Pantry = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
