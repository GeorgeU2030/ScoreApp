namespace backend.Models
{
    public class MatchSport
{
    public int MatchSportId { get; set; }

    public int TeamSportIdone { get; set; }
    public TeamSport Teamone { get; set; } = null!;

    public int TeamSportIdtwo { get; set; }
    public TeamSport Teamtwo { get; set; } = null!;
    public int? PointsTeamone { get; set; }
    public int? PointsTeamtwo { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
}
}