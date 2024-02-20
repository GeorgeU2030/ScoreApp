namespace backend.Models
{
    public class Match
{
    public int MatchId { get; set; }
    public int TeamSoccerIdone { get; set; }
    public TeamSoccer Teamone { get; set; } = null!;
    public int TeamSoccerIdtwo { get; set; }
    public TeamSoccer Teamtwo { get; set; } = null!;
    public int? TeamoneGoals { get; set; }
    public int? TeamtwoGoals { get; set; }
    public int? PenaltyTeamone { get; set; }
    public int? PenaltyTeamtwo { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
}
}