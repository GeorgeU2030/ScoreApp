using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Matchplayer
{
    public int MatchId { get; set; }

    public int? FirstPlayer { get; set; }

    public int? SecondPlayer { get; set; }

    public int? SetPlayer1 { get; set; }

    public int? SetPlayer2 { get; set; }

    public int? GameS1p1 { get; set; }

    public int? GameS1p2 { get; set; }

    public int? GameS2p1 { get; set; }

    public int? GameS2p2 { get; set; }

    public int? GameS3p1 { get; set; }

    public int? GameS3p2 { get; set; }

    public int? GameS4p1 { get; set; }

    public int? GameS4p2 { get; set; }

    public int? GameS5p1 { get; set; }

    public int? GameS5p2 { get; set; }

    public int? SeasonId { get; set; }

    public virtual Playerseason? FirstPlayerNavigation { get; set; }

    public virtual Season? Season { get; set; }

    public virtual Playerseason? SecondPlayerNavigation { get; set; }
}
