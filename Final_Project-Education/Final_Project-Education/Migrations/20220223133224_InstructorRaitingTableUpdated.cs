using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class InstructorRaitingTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Star",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "InstructorRaitings",
                type: "nvarchar(450)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorRaitings_AspNetUsers_CustomUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropIndex(
                name: "IX_InstructorRaitings_CustomUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Star",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "InstructorRaitings");
        }
    }
}
