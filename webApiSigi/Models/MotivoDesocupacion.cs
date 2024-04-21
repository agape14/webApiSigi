using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class MotivoDesocupacion
{
    public int IdMotivoDesocup { get; set; }

    public string? CodDesocup { get; set; }

    public string? NomDesocup { get; set; }

    public int? EstDesocup { get; set; }
}
