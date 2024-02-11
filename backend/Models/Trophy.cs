using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Trophy
{
    public int TrophyId { get; set; }

    public string? NameTrophy { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
