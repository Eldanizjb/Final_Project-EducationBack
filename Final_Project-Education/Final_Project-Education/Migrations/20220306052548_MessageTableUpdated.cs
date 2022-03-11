using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class MessageTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Commenters_CommenterId",
                table: "Comments");

            migrationBuilder.AddColumn<bool>(
                name: "Ready",
                table: "Messages",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommenterId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Commenters_CommenterId",
                table: "Comments",
                column: "CommenterId",
                principalTable: "Commenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Commenters_CommenterId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Ready",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "CommenterId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Commenters_CommenterId",
                table: "Comments",
                column: "CommenterId",
                principalTable: "Commenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
