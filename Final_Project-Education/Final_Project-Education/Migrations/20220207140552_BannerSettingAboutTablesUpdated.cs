using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Education.Migrations
{
    public partial class BannerSettingAboutTablesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "ImageBack",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "SupTitle",
                table: "Banners");

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Settings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerImageBack",
                table: "Settings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupTitle",
                table: "Settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "BannerImageBack",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "SupTitle",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Settings");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Banners",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageBack",
                table: "Banners",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupTitle",
                table: "Banners",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
