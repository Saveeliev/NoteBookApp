using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_NoteId_UserId",
                table: "Likes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Likes",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "NoteId",
                table: "Likes",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_NoteId_UserId",
                table: "Likes",
                columns: new[] { "NoteId", "UserId" },
                unique: true,
                filter: "[NoteId] IS NOT NULL AND [UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_NoteId_UserId",
                table: "Likes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "NoteId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Likes_NoteId_UserId",
                table: "Likes",
                columns: new[] { "NoteId", "UserId" },
                unique: true);
        }
    }
}
