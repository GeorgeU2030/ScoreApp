namespace backend.Models {
    public class PlayerSeason {
        public int PlayerSeasonId { get; set; }
        public string? Name { get; set; }
        public string? Photo { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; } = null!;
       
    }
}