using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string? NamePlayer { get; set; }

    public string? Photo { get; set; }

    public string? Flag { get; set; }

    public string? Country { get; set; }

    public int? Points { get; set; }

    public string? Genre { get; set; }

    public int? Aopen { get; set; }

    public int? Rgarros { get; set; }

    public int? Wimbledon { get; set; }

    public int? Usopen { get; set; }
}
