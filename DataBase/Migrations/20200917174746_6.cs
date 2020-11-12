using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favorites_NoteId",
                table: "Favorites");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_NoteId_UserId",
                table: "Favorites",
                columns: new[] { "NoteId", "UserId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favorites_NoteId_UserId",
                table: "Favorites");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_NoteId",
                table: "Favorites",
                column: "NoteId");
        }
    }
}
