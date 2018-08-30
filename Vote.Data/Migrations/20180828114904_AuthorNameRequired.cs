using Microsoft.EntityFrameworkCore.Migrations;

namespace Vote.Data.Migrations
{
    public partial class AuthorNameRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
