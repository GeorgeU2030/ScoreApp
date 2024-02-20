namespace backend.Models
{
    public class TeamSoccer
{
    public int TeamSoccerId { get; set; }
    public string? Name { get; set; }
    public string? Logo { get; set; }
    public int? Win { get; set; }
    public int? Draw { get; set; }
    public int? Lose { get; set; }
    public int? Points { get; set; }
    public int? Gf { get; set; }
    public int? Gc { get; set; }
    public int? Diff { get; set; }
    public int? Phase { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
}
}