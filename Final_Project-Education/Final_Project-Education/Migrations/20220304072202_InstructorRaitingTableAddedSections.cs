using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class InstructorRaitingTableAddedSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserIp",
                table: "InstructorRaitings",
                newName: "UserSurname");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndUserId",
                table: "InstructorRaitings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "InstructorRaitings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "InstructorRaitings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndUserId",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "InstructorRaitings");

            migrationBuilder.RenameColumn(
                name: "UserSurname",
                table: "InstructorRaitings",
                newName: "UserIp");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
