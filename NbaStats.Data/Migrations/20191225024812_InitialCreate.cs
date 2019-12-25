using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NbaStats.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(nullable: false),
                    HomeTeamId = table.Column<long>(nullable: false),
                    AwayTeamId = table.Column<long>(nullable: false),
                    HomeTeamScore = table.Column<int>(nullable: false),
                    AwayTeamScore = table.Column<int>(nullable: false),
                    HomeTeamName = table.Column<string>(nullable: true),
                    AwayTeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Teams_AwayTeamName",
                        column: x => x.AwayTeamName,
                        principalTable: "Teams",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_HomeTeamName",
                        column: x => x.HomeTeamName,
                        principalTable: "Teams",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                column: "Name",
                values: new object[]
                {
                    "Atlanta Hawks",
                    "Toronto Raptors",
                    "San Antonio Spurs",
                    "Sacramento Kings",
                    "Portland Trail Blazers",
                    "Phoenix Suns",
                    "Philadelphia 76ers",
                    "Orlando Magic",
                    "Oklahoma City Thunder",
                    "New York Knicks",
                    "New Orleans Pelicans",
                    "Minnesota Timberwolves",
                    "Milwaukee Bucks",
                    "Miami Heat",
                    "Memphis Grizzlies",
                    "Los Angeles Lakers",
                    "Los Angeles Clippers",
                    "Indiana Pacers",
                    "Houston Rockets",
                    "Golden State Warriors",
                    "Detroit Pistons",
                    "Denver Nuggers",
                    "Dallas Mavericks",
                    "Cleveland Cavaliers",
                    "Chicago Bulls",
                    "Charlotte Hornets",
                    "Brooklyn Nets",
                    "Boston Celtics",
                    "Utah Jazz",
                    "Washington Wizards"
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_AwayTeamName",
                table: "Games",
                column: "AwayTeamName");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeamName",
                table: "Games",
                column: "HomeTeamName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
