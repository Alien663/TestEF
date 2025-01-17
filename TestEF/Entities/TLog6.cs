using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class TLog6
{
    public DateTime? Time { get; set; }

    public string? Blade { get; set; }

    public string? Action { get; set; }

    public string? Type { get; set; }

    public string? Interface { get; set; }

    public string? Origin { get; set; }

    public string? Source { get; set; }

    public string? Source_User_Name { get; set; }

    public string? Destination { get; set; }

    public string? Service { get; set; }

    public short? Rule { get; set; }

    public string? Access_Rule_Name { get; set; }

    public string? Policy_Name { get; set; }

    public string? Description { get; set; }
}
