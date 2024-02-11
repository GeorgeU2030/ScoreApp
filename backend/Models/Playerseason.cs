using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Playerseason
{
    public int PlayerSeasonId { get; set; }

    public string? NamePlayerSeason { get; set; }

    public string? Photo { get; set; }

    public int? SeasonId { get; set; }

    public virtual ICollection<Matchplayer> MatchplayerFirstPlayerNavigations { get; set; } = new List<Matchplayer>();

    public virtual ICollection<Matchplayer> MatchplayerSecondPlayerNavigations { get; set; } = new List<Matchplayer>();

    public virtual Season? Season { get; set; }
}
