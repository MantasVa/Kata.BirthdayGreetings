using Microsoft.EntityFrameworkCore.Migrations;

namespace Kata.BirthdayGreetings.Data.Migrations
{
    public partial class AddedPhoneNumberToPersonDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Person");
        }
    }
}
