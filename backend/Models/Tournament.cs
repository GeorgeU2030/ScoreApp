
namespace backend.Models
{
    public class Tournament
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Logo { get; set; }
    public string? Flag { get; set; }

    public virtual ICollection<Season>? Seasons { get; set; }
}
}