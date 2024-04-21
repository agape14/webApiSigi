using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TSubastaPostorInmueble
{
    public int CodPostInm { get; set; }

    public int? CodSubasta { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public int? CodPostor { get; set; }

    public string? Estado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
