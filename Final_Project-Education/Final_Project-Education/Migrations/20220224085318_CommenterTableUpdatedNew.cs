using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class CommenterTableUpdatedNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Star",
                table: "Instructors");

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
                name: "IX_Commenters_InstructorId",
                table: "Commenters",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commenters_Instructors_InstructorId",
                table: "Commenters",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commenters_Instructors_InstructorId",
                table: "Commenters");

            migrationBuilder.DropIndex(
                name: "IX_Commenters_InstructorId",
                table: "Commenters");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Commenters");

            migrationBuilder.DropColumn(
                name: "RaitingInstructor",
                table: "Commenters");

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
        }
    }
}
