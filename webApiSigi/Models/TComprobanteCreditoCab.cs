using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TComprobanteCreditoCab
{
    public int CodComprobCredito { get; set; }

    public decimal? Total { get; set; }

    public decimal? Subtotal1 { get; set; }

    public decimal? Subtotal2 { get; set; }

    public string? FormaPago { get; set; }

    public decimal? TotalComprob { get; set; }

    public int? CodComprob { get; set; }

    public string? CodDetraccion { get; set; }
}
