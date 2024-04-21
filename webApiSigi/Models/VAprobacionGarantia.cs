using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class VAprobacionGarantia
{
    public int CodGcont { get; set; }

    public int CodContrato { get; set; }

    public int? NumContrato { get; set; }

    public int? Adenda { get; set; }

    public string? TipoArrendatario { get; set; }

    public string? Ocupantes { get; set; }

    public int Cum { get; set; }

    public int? Cuim { get; set; }

    public string? DescPredio { get; set; }

    public string NumInterno { get; set; } = null!;

    public decimal? Importe { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Motivo { get; set; }

    public string? Informe { get; set; }

    public string? OpinionLegal { get; set; }

    public int? CodOl { get; set; }

    public string? DocAprobacion { get; set; }

    public string? EstGarantia { get; set; }

    public decimal? GarantiaOblig { get; set; }

    public decimal? GarantiaReal { get; set; }

    public int? CodPcont { get; set; }

    public string? EstPago { get; set; }

    public decimal? DeudaTotalRenta { get; set; }

    public int? CodActo { get; set; }
}
