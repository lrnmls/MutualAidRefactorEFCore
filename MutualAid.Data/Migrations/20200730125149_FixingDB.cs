using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAid.Data.Migrations
{
    public partial class FixingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 30, 8, 51, 49, 301, DateTimeKind.Local).AddTicks(5249), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 30, 8, 49, 33, 762, DateTimeKind.Local).AddTicks(2745), true });
        }
    }
}
