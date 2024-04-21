using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TPlanillaCobranza
{
    public int CodPla { get; set; }

    public DateOnly? FecPlanilla { get; set; }

    public decimal? Total { get; set; }

    public decimal? Ajuste { get; set; }

    public decimal? TotalDeposito { get; set; }

    public string? EstPlanilla { get; set; }

    public DateOnly? FecPlanDepositos { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Numero { get; set; }

    public string? Generado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
