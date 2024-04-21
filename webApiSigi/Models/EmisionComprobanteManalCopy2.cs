using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class EmisionComprobanteManalCopy2
{
    public int Idtbl { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public int? Codconcepto { get; set; }

    public string? DescConcepto { get; set; }

    public string? Glosa { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? DniRuc { get; set; }

    public string? NombreRazsocial { get; set; }

    public decimal? Total { get; set; }

    public string? Mes { get; set; }

    public string? Anio { get; set; }

    public string? Documento { get; set; }

    public int? Procesado { get; set; }

    public int? RentaActualizado { get; set; }

    public int? Nvoid { get; set; }

    public string? Estado { get; set; }
}
