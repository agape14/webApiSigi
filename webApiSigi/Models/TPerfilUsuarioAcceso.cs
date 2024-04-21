using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TPerfilUsuarioAcceso
{
    public int CodPacceso { get; set; }

    public int? CodPerfil { get; set; }

    public string? CodModulo { get; set; }

    public string? Modulo { get; set; }

    public string? CodAcceso { get; set; }

    public string? Acceso { get; set; }

    public string? EstAcceso { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
