using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kata.BirthdayGreetings.Data.Migrations
{
    public partial class changedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
