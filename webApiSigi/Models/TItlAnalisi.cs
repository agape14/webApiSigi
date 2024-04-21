using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TItlAnalisi
{
    public int ItemItl { get; set; }

    public int? CodItl { get; set; }

    public int? NumItl { get; set; }

    public int? Item { get; set; }

    public string? Descripcion { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
