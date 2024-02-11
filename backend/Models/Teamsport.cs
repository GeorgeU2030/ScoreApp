using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Teamsport
{
    public int TeamSportId { get; set; }

    public string? NameTeamSport { get; set; }

    public string? LogoTs { get; set; }

    public int? Win { get; set; }

    public int? Lost { get; set; }

    public double? Percentage { get; set; }

    public int? SeasonId { get; set; }

    public virtual ICollection<Matchsport> MatchsportFirstTeamNavigations { get; set; } = new List<Matchsport>();

    public virtual ICollection<Matchsport> MatchsportSecondTeamNavigations { get; set; } = new List<Matchsport>();

    public virtual Season? Season { get; set; }
}
