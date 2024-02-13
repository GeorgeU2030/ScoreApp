using backend.Models;

namespace backend.DTO
{
    public class TournamentDTO
    {
        public Tournament? Tournament { get; set; }
        public List<Season>? Seasons { get; set; }       
    }
}