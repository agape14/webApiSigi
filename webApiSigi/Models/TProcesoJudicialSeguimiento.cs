using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicialSeguimiento
{
    public int CodPjseguimiento { get; set; }

    public int? CodPj { get; set; }

    public DateOnly? FecSeguimiento { get; set; }

    public string? Detalle { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
