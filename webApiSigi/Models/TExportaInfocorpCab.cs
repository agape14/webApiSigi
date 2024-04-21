using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TExportaInfocorpCab
{
    public int CodEinfocorp { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? CantTotReg { get; set; }

    public decimal? MontoTotEnv { get; set; }

    public string? EstExp { get; set; }

    public string? Archivo { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
