using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TAuditorium
{
    public int CodA { get; set; }

    public string? Tabla { get; set; }

    public string? ArchivoLog { get; set; }

    public string? Registro { get; set; }

    public DateTime? Fechahora { get; set; }

    public string? CodPersona { get; set; }

    public string? NombreCompleto { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
