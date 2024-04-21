using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TConceptoGasto
{
    public int CodConGas { get; set; }

    public string? Nombre { get; set; }

    public string? Estado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
