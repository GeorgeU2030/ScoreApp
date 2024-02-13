
namespace backend.Models
{
    public class Season
{
    public int Id { get; set; }
    public int Edition { get; set; }
    public string? Champion { get; set; }
    public string? SubChampion { get; set; }

    public int TournamentId { get; set; }
    public virtual Tournament? Tournament { get; set; }
}
}