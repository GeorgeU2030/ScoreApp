using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Racingteam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logoteam = table.Column<int>(type: "int", nullable: true),
                    Titles = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Australiaopen = table.Column<int>(type: "int", nullable: true),
                    Rolandgarros = table.Column<int>(type: "int", nullable: true),
                    Wimbledon = table.Column<int>(type: "int", nullable: true),
                    Usopen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentId);
                });

            migrationBuilder.CreateTable(
                name: "Winraces",
                columns: table => new
                {
                    WinraceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winraces", x => x.WinraceId);
                    table.ForeignKey(
                        name: "FK_Winraces_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trophies",
                columns: table => new
                {
                    TrophyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophies", x => x.TrophyId);
                    table.ForeignKey(
                        name: "FK_Trophies_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    ChampionId = table.Column<int>(type: "int", nullable: true),
                    SubChampionId = table.Column<int>(type: "int", nullable: true),
                    TournamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Teams_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Teams",
                        principalColumn: "TeamId");
                    table.ForeignKey(
                        name: "FK_Seasons_Teams_SubChampionId",
                        column: x => x.SubChampionId,
                        principalTable: "Teams",
                        principalColumn: "TeamId");
                    table.ForeignKey(
                        name: "FK_Seasons_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriversSeason",
                columns: table => new
                {
                    DriverSeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logoteam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seasonpoints = table.Column<int>(type: "int", nullable: true),
                    Seasonwins = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversSeason", x => x.DriverSeasonId);
                    table.ForeignKey(
                        name: "FK_DriversSeason_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayersSeason",
                columns: table => new
                {
                    PlayerSeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersSeason", x => x.PlayerSeasonId);
                    table.ForeignKey(
                        name: "FK_PlayersSeason_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamsSoccer",
                columns: table => new
                {
                    TeamSoccerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Win = table.Column<int>(type: "int", nullable: true),
                    Draw = table.Column<int>(type: "int", nullable: true),
                    Lose = table.Column<int>(type: "int", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: true),
                    Gf = table.Column<int>(type: "int", nullable: true),
                    Gc = table.Column<int>(type: "int", nullable: true),
                    Diff = table.Column<int>(type: "int", nullable: true),
                    Phase = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsSoccer", x => x.TeamSoccerId);
                    table.ForeignKey(
                        name: "FK_TeamsSoccer_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamsSport",
                columns: table => new
                {
                    TeamSportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Win = table.Column<int>(type: "int", nullable: true),
                    Lost = table.Column<int>(type: "int", nullable: true),
                    Percentage = table.Column<float>(type: "real", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsSport", x => x.TeamSportId);
                    table.ForeignKey(
                        name: "FK_TeamsSport_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    SecondId = table.Column<int>(type: "int", nullable: false),
                    ThirdId = table.Column<int>(type: "int", nullable: false),
                    FourthId = table.Column<int>(type: "int", nullable: false),
                    FifthId = table.Column<int>(type: "int", nullable: false),
                    SixthId = table.Column<int>(type: "int", nullable: false),
                    SeventhId = table.Column<int>(type: "int", nullable: false),
                    EighthId = table.Column<int>(type: "int", nullable: false),
                    NinthId = table.Column<int>(type: "int", nullable: false),
                    TenthId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_EighthId",
                        column: x => x.EighthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_FifthId",
                        column: x => x.FifthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_FourthId",
                        column: x => x.FourthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_NinthId",
                        column: x => x.NinthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_SecondId",
                        column: x => x.SecondId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_SeventhId",
                        column: x => x.SeventhId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_SixthId",
                        column: x => x.SixthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_TenthId",
                        column: x => x.TenthId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_ThirdId",
                        column: x => x.ThirdId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriversSeason_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "DriversSeason",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchesPlayer",
                columns: table => new
                {
                    MatchPlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerSeasonId = table.Column<int>(type: "int", nullable: false),
                    PlayerSeasonIdtwo = table.Column<int>(type: "int", nullable: false),
                    Setone = table.Column<int>(type: "int", nullable: true),
                    Settwo = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesPlayer", x => x.MatchPlayerId);
                    table.ForeignKey(
                        name: "FK_MatchesPlayer_PlayersSeason_PlayerSeasonId",
                        column: x => x.PlayerSeasonId,
                        principalTable: "PlayersSeason",
                        principalColumn: "PlayerSeasonId");
                    table.ForeignKey(
                        name: "FK_MatchesPlayer_PlayersSeason_PlayerSeasonIdtwo",
                        column: x => x.PlayerSeasonIdtwo,
                        principalTable: "PlayersSeason",
                        principalColumn: "PlayerSeasonId");
                    table.ForeignKey(
                        name: "FK_MatchesPlayer_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamSoccerIdone = table.Column<int>(type: "int", nullable: false),
                    TeamSoccerIdtwo = table.Column<int>(type: "int", nullable: false),
                    TeamoneGoals = table.Column<int>(type: "int", nullable: true),
                    TeamtwoGoals = table.Column<int>(type: "int", nullable: true),
                    PenaltyTeamone = table.Column<int>(type: "int", nullable: true),
                    PenaltyTeamtwo = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Matches_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_TeamsSoccer_TeamSoccerIdone",
                        column: x => x.TeamSoccerIdone,
                        principalTable: "TeamsSoccer",
                        principalColumn: "TeamSoccerId");
                    table.ForeignKey(
                        name: "FK_Matches_TeamsSoccer_TeamSoccerIdtwo",
                        column: x => x.TeamSoccerIdtwo,
                        principalTable: "TeamsSoccer",
                        principalColumn: "TeamSoccerId");
                });

            migrationBuilder.CreateTable(
                name: "MatchesSport",
                columns: table => new
                {
                    MatchSportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamSportIdone = table.Column<int>(type: "int", nullable: false),
                    TeamSportIdtwo = table.Column<int>(type: "int", nullable: false),
                    PointsTeamone = table.Column<int>(type: "int", nullable: true),
                    PointsTeamtwo = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesSport", x => x.MatchSportId);
                    table.ForeignKey(
                        name: "FK_MatchesSport_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchesSport_TeamsSport_TeamSportIdone",
                        column: x => x.TeamSportIdone,
                        principalTable: "TeamsSport",
                        principalColumn: "TeamSportId");
                    table.ForeignKey(
                        name: "FK_MatchesSport_TeamsSport_TeamSportIdtwo",
                        column: x => x.TeamSportIdtwo,
                        principalTable: "TeamsSport",
                        principalColumn: "TeamSportId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DriversSeason_SeasonId",
                table: "DriversSeason",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SeasonId",
                table: "Matches",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamSoccerIdone",
                table: "Matches",
                column: "TeamSoccerIdone");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamSoccerIdtwo",
                table: "Matches",
                column: "TeamSoccerIdtwo");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesPlayer_PlayerSeasonId",
                table: "MatchesPlayer",
                column: "PlayerSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesPlayer_PlayerSeasonIdtwo",
                table: "MatchesPlayer",
                column: "PlayerSeasonIdtwo");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesPlayer_SeasonId",
                table: "MatchesPlayer",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesSport_SeasonId",
                table: "MatchesSport",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesSport_TeamSportIdone",
                table: "MatchesSport",
                column: "TeamSportIdone");

            migrationBuilder.CreateIndex(
                name: "IX_MatchesSport_TeamSportIdtwo",
                table: "MatchesSport",
                column: "TeamSportIdtwo");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersSeason_SeasonId",
                table: "PlayersSeason",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_EighthId",
                table: "Races",
                column: "EighthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_FifthId",
                table: "Races",
                column: "FifthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_FourthId",
                table: "Races",
                column: "FourthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_NinthId",
                table: "Races",
                column: "NinthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SeasonId",
                table: "Races",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SecondId",
                table: "Races",
                column: "SecondId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SeventhId",
                table: "Races",
                column: "SeventhId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SixthId",
                table: "Races",
                column: "SixthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_TenthId",
                table: "Races",
                column: "TenthId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_ThirdId",
                table: "Races",
                column: "ThirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_WinnerId",
                table: "Races",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_ChampionId",
                table: "Seasons",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SubChampionId",
                table: "Seasons",
                column: "SubChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_TournamentId",
                table: "Seasons",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSoccer_SeasonId",
                table: "TeamsSoccer",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSport_SeasonId",
                table: "TeamsSport",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Trophies_TeamId",
                table: "Trophies",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Winraces_DriverId",
                table: "Winraces",
                column: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "MatchesPlayer");

            migrationBuilder.DropTable(
                name: "MatchesSport");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Trophies");

            migrationBuilder.DropTable(
                name: "Winraces");

            migrationBuilder.DropTable(
                name: "TeamsSoccer");

            migrationBuilder.DropTable(
                name: "PlayersSeason");

            migrationBuilder.DropTable(
                name: "TeamsSport");

            migrationBuilder.DropTable(
                name: "DriversSeason");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
