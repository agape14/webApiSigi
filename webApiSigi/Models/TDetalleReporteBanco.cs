using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TDetalleReporteBanco
{
    public int? IdDetalleReporteBanco { get; set; }

    public string? Fecha { get; set; }

    public int? MesReporte { get; set; }

    public int? AnioReporte { get; set; }

    public string? FechaValuta { get; set; }

    public string? DescripcionReporteBanco { get; set; }

    public decimal? MontoReporteBanco { get; set; }
}
