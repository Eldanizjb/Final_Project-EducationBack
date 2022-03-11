using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class CourseLevelToCourseTableRemowe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseLevelToCourses");

            migrationBuilder.AddColumn<int>(
                name: "CourseLevelId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseLevelId",
                table: "Courses",
                column: "CourseLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseLevel_CourseLevelId",
                table: "Courses",
                column: "CourseLevelId",
                principalTable: "CourseLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseLevel_CourseLevelId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseLevelId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseLevelId",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CourseLevelToCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CourseLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLevelToCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseLevelToCourses_CourseLevel_CourseLevelId",
                        column: x => x.CourseLevelId,
                        principalTable: "CourseLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseLevelToCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLevelToCourses_CourseId",
                table: "CourseLevelToCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLevelToCourses_CourseLevelId",
                table: "CourseLevelToCourses",
                column: "CourseLevelId");
        }
    }
}
