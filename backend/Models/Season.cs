
namespace backend.Models
{
    public class Season
{
    public int SeasonId { get; set; }
    public int Edition { get; set; }
    public int? ChampionId { get; set; }
    public Team? Champion { get; set; }
    public int? SubChampionId { get; set; }
    public Team? SubChampion { get; set; }
    public int TournamentId { get; set; }
    public Tournament Tournament { get; set; } = null!;
    public ICollection<TeamSoccer>? TeamsSoccer { get; set; } = new List<TeamSoccer>();
    public ICollection<TeamSport>? TeamsSport { get; set; } = new List<TeamSport>();
    public ICollection<PlayerSeason>? PlayersSeason { get; set; } = new List<PlayerSeason>();
    public ICollection<Match>? Matches { get; set; } = new List<Match>();
    public ICollection<MatchSport>? MatchesSport { get; set; } = new List<MatchSport>();
    public ICollection<MatchPlayer>? MatchesPlayer { get; set; } = new List<MatchPlayer>();
    public ICollection<DriverSeason>? DriversSeason { get; set; } = new List<DriverSeason>();
    public ICollection<Race>? Races { get; set;} = new List<Race>(); 
}
}