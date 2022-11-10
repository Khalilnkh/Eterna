using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class UpdatedTeamTrainerReleatedWithTeamPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeamTrainers_TeamPositionID",
                table: "TeamTrainers",
                column: "TeamPositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTrainers_TeamPositions_TeamPositionID",
                table: "TeamTrainers",
                column: "TeamPositionID",
                principalTable: "TeamPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamTrainers_TeamPositions_TeamPositionID",
                table: "TeamTrainers");

            migrationBuilder.DropIndex(
                name: "IX_TeamTrainers_TeamPositionID",
                table: "TeamTrainers");
        }
    }
}
