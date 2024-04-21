using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TDeudasXTrimestre
{
    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public string? Direccion { get; set; }

    public string? NumInterior { get; set; }

    public decimal? AreaTotal { get; set; }

    public int? Cuotas { get; set; }

    public string? Administrados { get; set; }

    public string? Pjudicial { get; set; }

    public string? EjecucionPj { get; set; }

    public decimal? Renta { get; set; }

    public decimal? GarantiaReal { get; set; }

    public string? FecInicio { get; set; }

    public string? FecFin { get; set; }

    public int? Coduso { get; set; }

    public string? Uso { get; set; }

    public decimal? TotalDeuda { get; set; }

    public string? Ocupado { get; set; }

    public string? Inquilino { get; set; }

    public int? CodContrato { get; set; }

    public int? TotalCuota1700 { get; set; }

    public decimal? TotalDeuda1700 { get; set; }

    public string? FecActual { get; set; }
}
