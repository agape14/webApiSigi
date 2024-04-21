using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TTiponotum
{
    public int IdTipoNota { get; set; }

    public string? TipoNotaNombre { get; set; }

    public string? TipoNotaDc { get; set; }

    public int? TipoNotaEstado { get; set; }

    public string? TipoNotaCodigo { get; set; }
}
