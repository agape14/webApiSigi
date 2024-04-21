using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TFotoProvisional
{
    public int? CodProv { get; set; }

    public string? Imagen { get; set; }

    public string? Comentario { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
