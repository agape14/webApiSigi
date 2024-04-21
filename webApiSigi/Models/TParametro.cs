using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TParametro
{
    public string CodParam { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Abrev { get; set; }

    public string? Adm { get; set; }

    public int? Nivelmax { get; set; }

    public string? EstParam { get; set; }

    public string? SubListas { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
