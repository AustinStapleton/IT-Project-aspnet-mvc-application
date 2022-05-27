using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT_Project.Migrations
{
    public partial class RatingNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rate_RateId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rate",
                table: "Rate");

            migrationBuilder.RenameTable(
                name: "Rate",
                newName: "Rating");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rating_RateId",
                table: "Movies",
                column: "RateId",
                principalTable: "Rating",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rating_RateId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Rate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rate",
                table: "Rate",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rate_RateId",
                table: "Movies",
                column: "RateId",
                principalTable: "Rate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
