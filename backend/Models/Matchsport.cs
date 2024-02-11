using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Matchsport
{
    public int MatchSportId { get; set; }

    public int? FirstTeam { get; set; }

    public int? SecondTeam { get; set; }

    public int? Pteam1 { get; set; }

    public int? Pteam2 { get; set; }

    public int? SeasonId { get; set; }

    public virtual Teamsport? FirstTeamNavigation { get; set; }

    public virtual Season? Season { get; set; }

    public virtual Teamsport? SecondTeamNavigation { get; set; }
}
