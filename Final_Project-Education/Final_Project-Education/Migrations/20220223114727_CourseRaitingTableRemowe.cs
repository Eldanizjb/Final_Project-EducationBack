using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class CourseRaitingTableRemowe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRaitings");

            migrationBuilder.DropColumn(
                name: "RatingAmount",
                table: "InstructorRaitings");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "InstructorRaitings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Rang",
                table: "InstructorRaitings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "InstructorRaitings");

            migrationBuilder.DropColumn(
                name: "Rang",
                table: "InstructorRaitings");

            migrationBuilder.AddColumn<byte>(
                name: "RatingAmount",
                table: "InstructorRaitings",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "CourseRaitings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    RatingAmount = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRaitings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseRaitings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRaitings_CourseId",
                table: "CourseRaitings",
                column: "CourseId");
        }
    }
}
