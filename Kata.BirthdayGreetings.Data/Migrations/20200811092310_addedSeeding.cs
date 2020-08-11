using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kata.BirthdayGreetings.Data.Migrations
{
    public partial class addedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "valuckas.mantas@gmail.com", "Mantas", "Valuckas", "865741254" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rutenis@gmail.com", "Rutenis", "Naugzemis", "865741254" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3, new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "aidanas93@gmail.com", "Aidanas", "Naugzemis", "864741327" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
