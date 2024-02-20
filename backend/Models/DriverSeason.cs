namespace backend.Models
{
    public class DriverSeason
{
    public int DriverSeasonId { get; set; }
    public string? Name { get; set; }
    public string? Photo { get; set; }
    public string? Logoteam { get; set; }
    public int? Seasonpoints { get; set; }
    public int? Seasonwins { get; set; }
    public int SeasonId { get; set; }
    public Season Season { get; set; } = null!;
}
}