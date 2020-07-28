using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAid.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "County", "Created", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Salt", "isAdmin" },
                values: new object[] { 1, "Franklin", new DateTime(2020, 7, 28, 14, 22, 7, 261, DateTimeKind.Local).AddTicks(3233), "lauren.miles@kizan.com", "Lauren", "Miles", "Password1", "9373291424", "2xbXMH/6gxk=", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
