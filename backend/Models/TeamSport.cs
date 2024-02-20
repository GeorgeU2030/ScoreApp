namespace backend.Models
{
    public class TeamSport
{
    public int TeamSportId { get; set; }
    public string? Name { get; set; }
    public string? Logo { get; set; }
    public int? Win { get; set; }
    public int? Lost { get; set; }
    public float? Percentage { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
}
}