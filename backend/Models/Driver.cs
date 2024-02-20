namespace backend.Models
{
    public class Driver
{
    public int DriverId { get; set; }
    public string? Name { get; set; }
    public string? Photo { get; set; }
    public string? Flag { get; set; }
    public string? Country { get; set; }
    public string? Racingteam { get; set; }
    public int? Logoteam { get; set; }
    public int? Titles { get; set; }
    public ICollection<Winrace>? Winraces { get; set; } = new List<Winrace>();
}
}