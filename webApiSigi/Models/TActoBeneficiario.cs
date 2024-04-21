using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TActoBeneficiario
{
    public int? CodBenef { get; set; }

    public int? CodActo { get; set; }

    public string? CodPersona { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
