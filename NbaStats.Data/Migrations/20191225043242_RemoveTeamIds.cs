using Microsoft.EntityFrameworkCore.Migrations;

namespace NbaStats.Data.Migrations
{
    public partial class RemoveTeamIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayTeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "HomeTeamId",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AwayTeamId",
                table: "Games",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "HomeTeamId",
                table: "Games",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
