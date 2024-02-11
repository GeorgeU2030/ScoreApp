using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Teamsoccer
{
    public int TeamSoccerId { get; set; }

    public string? NameTeamSoccer { get; set; }

    public string? LogoSt { get; set; }

    public int? Win { get; set; }

    public int? Draw { get; set; }

    public int? Lost { get; set; }

    public int? Points { get; set; }

    public int? Gd { get; set; }

    public int? Gf { get; set; }

    public int? Gc { get; set; }

    public int? SeasonId { get; set; }

    public int? PhaseTeam { get; set; }

    public virtual ICollection<Matchsoccer> MatchsoccerFirstTeamNavigations { get; set; } = new List<Matchsoccer>();

    public virtual ICollection<Matchsoccer> MatchsoccerSecondTeamNavigations { get; set; } = new List<Matchsoccer>();

    public virtual Season? Season { get; set; }
}
