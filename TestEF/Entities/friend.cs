using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class friend
{
    public long graph_id_645B659393D3472D87928EE05D4A3F2A { get; set; }

    public string _edge_id_B75FB4408B7349C086619523700698AE { get; set; } = null!;

    public int from_obj_id_A4726CBE4C5E484980BDB9764A7CE913 { get; set; }

    public long from_id_D20EE1CEC55C4109BB388568194CAE3E { get; set; }

    public string? _from_id_2EB76BD9E0DE4F5791443314EE7DA090 { get; set; }

    public int to_obj_id_40BAA0479F634587AB6FE8E116C42375 { get; set; }

    public long to_id_E65FA6A08D254BF799D3D77CF1BE437A { get; set; }

    public string? _to_id_088A46B44DE6486088F32EEA9FF24BEE { get; set; }

    public DateOnly? StartDate { get; set; }
}
