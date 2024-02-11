using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Season
{
    public int SeasonId { get; set; }

    public int? Edition { get; set; }

    public int? Champion { get; set; }

    public int? SubChampion { get; set; }

    public int? TournamentId { get; set; }

    public virtual Team? ChampionNavigation { get; set; }

    public virtual ICollection<Driverseason> Driverseasons { get; set; } = new List<Driverseason>();

    public virtual ICollection<Matchplayer> Matchplayers { get; set; } = new List<Matchplayer>();

    public virtual ICollection<Matchsoccer> Matchsoccers { get; set; } = new List<Matchsoccer>();

    public virtual ICollection<Matchsport> Matchsports { get; set; } = new List<Matchsport>();

    public virtual ICollection<Playerseason> Playerseasons { get; set; } = new List<Playerseason>();

    public virtual ICollection<Race> Races { get; set; } = new List<Race>();

    public virtual Team? SubChampionNavigation { get; set; }

    public virtual ICollection<Teamsoccer> Teamsoccers { get; set; } = new List<Teamsoccer>();

    public virtual ICollection<Teamsport> Teamsports { get; set; } = new List<Teamsport>();

    public virtual Tournament? Tournament { get; set; }
}
