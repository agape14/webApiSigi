using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TContratoPersona
{
    public int CodCpers { get; set; }

    public int? CodContrato { get; set; }

    public string? CodPersona { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
