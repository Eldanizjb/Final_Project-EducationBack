using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class AllTablesUploads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorRaitings_AspNetUsers_CustomUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropIndex(
                name: "IX_InstructorRaitings_CustomUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Commenters");

            migrationBuilder.DropColumn(
                name: "RaitingInstructor",
                table: "Commenters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "InstructorRaitings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Commenters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaitingInstructor",
                table: "Commenters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorRaitings_CustomUserId",
                table: "InstructorRaitings",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorRaitings_AspNetUsers_CustomUserId",
                table: "InstructorRaitings",
                column: "CustomUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
