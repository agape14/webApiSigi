using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicialDoc
{
    public int CodPjdoc { get; set; }

    public int? CodPj { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Resumen { get; set; }

    public string? Archivo { get; set; }

    public DateOnly? FecDoc { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
