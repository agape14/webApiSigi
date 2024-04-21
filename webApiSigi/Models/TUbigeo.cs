using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TUbigeo
{
    public string CodUbi { get; set; } = null!;

    public string? Dpto { get; set; }

    public string? Prov { get; set; }

    public string? Dist { get; set; }

    public int? PeriodoPredial { get; set; }

    public int? PeriodoArbitrios { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
