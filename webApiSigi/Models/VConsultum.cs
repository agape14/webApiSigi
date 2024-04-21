using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class VConsultum
{
    public int CodContrato { get; set; }

    public int? CodIngreso { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? TotalDeuda { get; set; }

    public int? Numcontrato { get; set; }

    public int? CodComprob { get; set; }

    public int? Ticket { get; set; }

    public string? DocumentoPago { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? Detalle { get; set; }

    public decimal? Total { get; set; }

    public decimal? Importe { get; set; }

    public string? CodPersona { get; set; }

    public string? NombreCompletoSunat { get; set; }

    public string? Observaciones { get; set; }
}
