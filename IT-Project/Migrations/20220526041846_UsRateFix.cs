using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT_Project.Migrations
{
    public partial class UsRateFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Rating");

            migrationBuilder.AddColumn<string>(
                name: "UsRate",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsRate",
                table: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
