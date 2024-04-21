using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicialCitum
{
    public int CodPjcita { get; set; }

    public int? CodPj { get; set; }

    public DateTime? FecCita { get; set; }

    public string? Asunto { get; set; }

    public string? Observaciones { get; set; }

    public string? TipoCita { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
