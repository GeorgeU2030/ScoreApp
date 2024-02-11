using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Driver
{
    public int DriverId { get; set; }

    public string? NameDriver { get; set; }

    public string? Photo { get; set; }

    public string? Country { get; set; }

    public string? Flag { get; set; }

    public string? RacingTeam { get; set; }

    public string? LogoTeam { get; set; }

    public int? Points { get; set; }

    public int? Titles { get; set; }

    public virtual ICollection<Winrace> Winraces { get; set; } = new List<Winrace>();
}
