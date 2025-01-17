using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class TLOG_Result
{
    public string? Source { get; set; }

    public string? Destination { get; set; }

    public string? Service { get; set; }

    public int RID { get; set; }
}
