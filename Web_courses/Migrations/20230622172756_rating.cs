using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_courses.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ratings",
                table: "Course",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "reviews",
                table: "Course",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ratings",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "reviews",
                table: "Course");
        }
    }
}
