using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAid.Data.Migrations
{
    public partial class UpdateAdminUserPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Password", "Salt", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 28, 15, 6, 11, 818, DateTimeKind.Local).AddTicks(7257), "cbpwtZPsJD3FWtBrCS37LF8NMKc=", "ItM0F+lRxK4=", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Password", "Salt", "isAdmin" },
                values: new object[] { new DateTime(2020, 7, 28, 14, 22, 7, 261, DateTimeKind.Local).AddTicks(3233), "Password1", "2xbXMH/6gxk=", true });
        }
    }
}
