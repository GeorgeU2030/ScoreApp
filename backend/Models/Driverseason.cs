using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Driverseason
{
    public int DriverSeasonId { get; set; }

    public string? NameDriverSeason { get; set; }

    public string? Photo { get; set; }

    public string? LogoTeam { get; set; }

    public int? SeasonPoints { get; set; }

    public int? SeasonWins { get; set; }

    public int? SeasonId { get; set; }

    public virtual ICollection<Race> RaceEighthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceFifthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceFourthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceNinthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceSecondNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceSeventhNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceSixthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceTenthNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceThirdNavigations { get; set; } = new List<Race>();

    public virtual ICollection<Race> RaceWinnerNavigations { get; set; } = new List<Race>();

    public virtual Season? Season { get; set; }
}
