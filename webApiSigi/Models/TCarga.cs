using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TCarga
{
    public int? CodCarga { get; set; }

    public int? CodProv { get; set; }

    public int? Cum { get; set; }

    public int? Num { get; set; }

    public string? Carga { get; set; }

    public string? EntCarga { get; set; }

    public DateOnly? FecCarga { get; set; }

    public string? VigCarga { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
