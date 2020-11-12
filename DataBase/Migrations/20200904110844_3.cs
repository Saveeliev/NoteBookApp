using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Notes_NoteId",
                table: "Likes");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Notes_NoteId",
                table: "Likes",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Notes_NoteId",
                table: "Likes");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Notes_NoteId",
                table: "Likes",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
