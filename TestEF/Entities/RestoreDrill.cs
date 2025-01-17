using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class RestoreDrill
{
    public int RID { get; set; }

    public string? DBName { get; set; }

    public string? BackupFile { get; set; }

    public int? Counts { get; set; }

    public bool? State { get; set; }

    public string? Context { get; set; }

    public DateTime? LastUpdate { get; set; }
}
