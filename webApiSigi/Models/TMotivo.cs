using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TMotivo
{
    public string CodMotivo { get; set; } = null!;

    public string? DescMotivo { get; set; }

    public int? Estado { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? OrdenMotivo { get; set; }
}
