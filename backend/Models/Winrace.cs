using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Winrace
{
    public int WinraceId { get; set; }

    public string? NameRace { get; set; }

    public int? Driver { get; set; }

    public virtual Driver? DriverNavigation { get; set; }
}
