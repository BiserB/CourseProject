using Microsoft.EntityFrameworkCore.Migrations;

namespace Vote.Data.Migrations
{
    public partial class UserHasLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasLogo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasLogo",
                table: "AspNetUsers");
        }
    }
}
