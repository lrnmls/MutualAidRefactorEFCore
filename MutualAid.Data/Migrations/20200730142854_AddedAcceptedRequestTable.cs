using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAid.Data.Migrations
{
    public partial class AddedAcceptedRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accepted Request",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accepted Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accepted Request_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accepted Request_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 28, 53, 949, DateTimeKind.Local).AddTicks(1804), true });

            migrationBuilder.CreateIndex(
                name: "IX_Accepted Request_RequestId",
                table: "Accepted Request",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Accepted Request_UserId",
                table: "Accepted Request",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accepted Request");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 30, 8, 51, 49, 301, DateTimeKind.Local).AddTicks(5249), true });
        }
    }
}
