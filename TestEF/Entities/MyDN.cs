using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class MyDN
{
    public string? ServerName { get; set; }

    public string ServerIP { get; set; } = null!;
}
