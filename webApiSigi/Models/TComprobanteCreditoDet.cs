using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TComprobanteCreditoDet
{
    public int CodComprobCredDet { get; set; }

    public int? CodComprobCred { get; set; }

    public string? Cuota { get; set; }

    public int? Correlativo { get; set; }

    public string? VCorrelativo { get; set; }

    public decimal? ValorCredito { get; set; }

    public DateOnly? FechaVencimiento { get; set; }
}
