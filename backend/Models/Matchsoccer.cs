using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Matchsoccer
{
    public int MatchId { get; set; }

    public int? FirstTeam { get; set; }

    public int? SecondTeam { get; set; }

    public int? Gteam1 { get; set; }

    public int? Gteam2 { get; set; }

    public int? Penal1 { get; set; }

    public int? Penal2 { get; set; }

    public int? SeasonId { get; set; }

    public virtual Teamsoccer? FirstTeamNavigation { get; set; }

    public virtual Season? Season { get; set; }

    public virtual Teamsoccer? SecondTeamNavigation { get; set; }
}
