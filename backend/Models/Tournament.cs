
namespace backend.Models
{
    public class Tournament
{
    public int TournamentId { get; set; }
    public string? Name { get; set; }
    public string? Logo { get; set; }
    public string? Flag { get; set; }

    public ICollection<Season>? Seasons { get; set; } = new List<Season>();
}
}