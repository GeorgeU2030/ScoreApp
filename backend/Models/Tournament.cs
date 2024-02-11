using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Tournament
{
    public int TournamentId { get; set; }

    public string? NameTournament { get; set; }

    public string? LogoTournament { get; set; }

    public virtual ICollection<Season> Seasons { get; set; } = new List<Season>();
}
