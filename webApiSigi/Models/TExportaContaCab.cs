using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TExportaContaCab
{
    public int CodEconta { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateOnly? FecHasta { get; set; }

    public int? Mes { get; set; }

    public string? EstExpConta { get; set; }

    public DateOnly? FecDesde { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
