using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class TablesUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commenters_Instructors_InstructorId",
                table: "Commenters");

            migrationBuilder.DropIndex(
                name: "IX_Commenters_InstructorId",
                table: "Commenters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
