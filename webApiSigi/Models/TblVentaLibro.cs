using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TblVentaLibro
{
    public int Id { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public string? CodPersona { get; set; }

    public string? NombreRazonSocial { get; set; }

    public decimal? Total { get; set; }

    public string? NombreLibro { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Cantidad { get; set; }
}
