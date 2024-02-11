using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Race
{
    public int RaceId { get; set; }

    public string? NameRace { get; set; }

    public string? FlagRace { get; set; }

    public int? Winner { get; set; }

    public int? Second { get; set; }

    public int? Third { get; set; }

    public int? Fourth { get; set; }

    public int? Fifth { get; set; }

    public int? Sixth { get; set; }

    public int? Seventh { get; set; }

    public int? Eighth { get; set; }

    public int? Ninth { get; set; }

    public int? Tenth { get; set; }

    public int? SeasonId { get; set; }

    public virtual Driverseason? EighthNavigation { get; set; }

    public virtual Driverseason? FifthNavigation { get; set; }

    public virtual Driverseason? FourthNavigation { get; set; }

    public virtual Driverseason? NinthNavigation { get; set; }

    public virtual Season? Season { get; set; }

    public virtual Driverseason? SecondNavigation { get; set; }

    public virtual Driverseason? SeventhNavigation { get; set; }

    public virtual Driverseason? SixthNavigation { get; set; }

    public virtual Driverseason? TenthNavigation { get; set; }

    public virtual Driverseason? ThirdNavigation { get; set; }

    public virtual Driverseason? WinnerNavigation { get; set; }
}
