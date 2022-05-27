using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT_Project.Migrations
{
    public partial class droppedratefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RateId",
                table: "Movies",
                column: "RateId");

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

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Movies_RateId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RateId",
                table: "Movies");
        }
    }
}
