using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TReprogramaDeudaContrato
{
    public int CodRdcont { get; set; }

    public int CodContrato { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? InteresDiario { get; set; }

    public decimal? InteresAcumulado { get; set; }

    public decimal? TotalDeuda { get; set; }

    public int? CuotasRestantes { get; set; }

    public int? CuotasProgramadas { get; set; }

    public decimal? ImporteCuota { get; set; }

    public DateOnly? FecReprogramacion { get; set; }

    public string? DocReprogramacion { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
