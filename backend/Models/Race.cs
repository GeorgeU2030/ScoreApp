namespace backend.Models {
    public class Race {
        public int RaceId {get; set;}
        public string? Name {get; set;}
        public string? Flagrace {get; set;}
        public int WinnerId {get; set;}
        public DriverSeason Winner {get; set;} = null!;
        public int SecondId {get; set;}
        public DriverSeason Second {get; set;} = null!;
        public int ThirdId {get; set;}
        public DriverSeason Third {get; set;} = null!;
        public int FourthId {get; set;}
        public DriverSeason Fourth {get; set;} = null!;
        public int FifthId {get; set;}
        public DriverSeason Fifth {get; set;} = null!;
        public int SixthId {get; set;}
        public DriverSeason Sixth {get; set;} = null!;
        public int SeventhId {get; set;}
        public DriverSeason Seventh {get; set;} = null!;
        public int EighthId {get; set;}
        public DriverSeason Eighth {get; set;} = null!;
        public int NinthId {get; set;}
        public DriverSeason Ninth {get; set;} = null!;
        public int TenthId {get; set;}
        public DriverSeason Tenth {get; set;} = null!;
        public int SeasonId {get; set;}
        public Season Season {get; set;} = null!; 
    }
}