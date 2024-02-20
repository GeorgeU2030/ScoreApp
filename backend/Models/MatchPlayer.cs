namespace backend.Models
{
    public class MatchPlayer
{
    public int MatchPlayerId { get; set; }
    public int PlayerSeasonId { get; set; }
    public PlayerSeason Playerone { get; set; } = null!;
    public int PlayerSeasonIdtwo { get; set; }
    public PlayerSeason Playertwo { get; set; } = null!;
    public int? Setone { get; set; }
    public int? Settwo { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
    
}
}