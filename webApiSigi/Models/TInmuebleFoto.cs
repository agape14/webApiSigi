using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TInmuebleFoto
{
    public int CodFcum { get; set; }

    public int? Cum { get; set; }

    public string? Archivo { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
