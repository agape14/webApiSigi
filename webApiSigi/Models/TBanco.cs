using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TBanco
{
    public int CodBanco { get; set; }

    public string? Nombre { get; set; }

    public string? Abrev { get; set; }

    public string? NumCuenta { get; set; }

    public string? CContable { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
