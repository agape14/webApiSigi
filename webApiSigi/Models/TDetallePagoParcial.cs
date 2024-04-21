using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TDetallePagoParcial
{
    public int CodDpagPar { get; set; }

    public int? CodComprobante { get; set; }

    public DateOnly? FechaPago { get; set; }

    public decimal? TotalPago { get; set; }

    public decimal? APagar { get; set; }

    public decimal? Saldo { get; set; }

    public string? CtaContable { get; set; }

    public decimal? PorcPago { get; set; }
}
