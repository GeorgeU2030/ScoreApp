
namespace backend.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; }
        public string? Flag { get; set; }
        public int? Division { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public ICollection<Trophy>? Trophies { get; set; } = new List<Trophy>();
    }
}
