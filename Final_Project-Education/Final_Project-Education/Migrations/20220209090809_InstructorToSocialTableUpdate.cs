using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class InstructorToSocialTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorToSocials_Socials_SocialId",
                table: "InstructorToSocials");

            migrationBuilder.DropIndex(
                name: "IX_InstructorToSocials_SocialId",
                table: "InstructorToSocials");

            migrationBuilder.DropColumn(
                name: "SocialId",
                table: "InstructorToSocials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialId",
                table: "InstructorToSocials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorToSocials_SocialId",
                table: "InstructorToSocials",
                column: "SocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorToSocials_Socials_SocialId",
                table: "InstructorToSocials",
                column: "SocialId",
                principalTable: "Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
