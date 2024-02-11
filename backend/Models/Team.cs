using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string? NameTeam { get; set; }

    public string? Flag { get; set; }

    public string? Country { get; set; }

    public string? Logo { get; set; }

    public int? Division { get; set; }

    public string? City { get; set; }

    public virtual ICollection<Season> SeasonChampionNavigations { get; set; } = new List<Season>();

    public virtual ICollection<Season> SeasonSubChampionNavigations { get; set; } = new List<Season>();

    public virtual ICollection<Trophy> Trophies { get; set; } = new List<Trophy>();
}
