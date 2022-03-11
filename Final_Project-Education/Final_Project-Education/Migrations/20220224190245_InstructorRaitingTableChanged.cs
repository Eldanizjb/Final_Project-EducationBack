using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class InstructorRaitingTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "InstructorRaitings");

            migrationBuilder.RenameColumn(
                name: "Rang",
                table: "InstructorRaitings",
                newName: "Star");

            migrationBuilder.AddColumn<string>(
                name: "UserIp",
                table: "InstructorRaitings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIp",
                table: "InstructorRaitings");

            migrationBuilder.RenameColumn(
                name: "Star",
                table: "InstructorRaitings",
                newName: "Rang");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "InstructorRaitings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
