using Microsoft.EntityFrameworkCore.Migrations;

namespace Day4.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "users");

            migrationBuilder.DropColumn(
                name: "email",
                table: "users");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "users");

            migrationBuilder.DropColumn(
                name: "location",
                table: "users");
        }
    }
}
