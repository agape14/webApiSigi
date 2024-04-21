using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class Sysdiagram
{
    public string Name { get; set; } = null!;

    public int PrincipalId { get; set; }

    public int DiagramId { get; set; }

    public int? Version { get; set; }

    public byte[]? Definition { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
