using Microsoft.EntityFrameworkCore.Migrations;

namespace Vote.Data.Migrations
{
    public partial class ReplyAuthorNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId1",
                table: "Replies");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId1",
                table: "Replies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Replies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId1",
                table: "Replies",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId1",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Replies");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId1",
                table: "Replies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId1",
                table: "Replies",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
