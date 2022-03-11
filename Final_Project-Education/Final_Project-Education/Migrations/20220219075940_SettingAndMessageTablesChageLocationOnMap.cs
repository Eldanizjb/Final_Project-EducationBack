using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class SettingAndMessageTablesChageLocationOnMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationOnMap",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "LocationOnMap",
                table: "Settings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationOnMap",
                table: "Settings");

            migrationBuilder.AddColumn<string>(
                name: "LocationOnMap",
                table: "Messages",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
