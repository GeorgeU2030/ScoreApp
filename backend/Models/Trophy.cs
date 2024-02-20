namespace backend.Models
{
    public class Trophy
{
    public int TrophyId { get; set; }
    public string? Name { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; } = null!;
}
}