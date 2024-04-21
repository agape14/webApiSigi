using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicialEtapa
{
    public int CodPje { get; set; }

    public int? CodPj { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Etapa { get; set; }

    public string? Documento { get; set; }

    public string? EstEtapa { get; set; }

    public string? CodEtapa { get; set; }

    public string? NumEtapa { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
