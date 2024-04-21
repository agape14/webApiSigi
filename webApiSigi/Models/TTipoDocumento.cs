using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TTipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string? CodTipoDocumento { get; set; }

    public string? DescTipoDocumento { get; set; }

    public string? DescCortaTipDoc { get; set; }

    public int? Longitud { get; set; }

    public string? Tipo { get; set; }

    public string? TipoContribuyente { get; set; }

    public string? LongExacta { get; set; }
}
