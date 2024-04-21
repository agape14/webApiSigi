using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TGasto
{
    public int CodGasto { get; set; }

    public int Cum { get; set; }

    public int Cuim { get; set; }

    public string? TipoGasto { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Anio { get; set; }

    public string? TipoPeriodo { get; set; }

    public int? Periodo { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? InteresDiario { get; set; }

    public int? DiasAtrazados { get; set; }

    public decimal? InteresAcumulado { get; set; }

    public decimal? TotalDeuda { get; set; }

    public decimal? Pagado { get; set; }

    public string? Responsable { get; set; }

    public string? DocPago { get; set; }

    public string? Estado { get; set; }

    public string? Detalle { get; set; }

    public string? Direccion { get; set; }

    public int? CodActo { get; set; }

    public string? CodPersonaOcup { get; set; }

    public string? NombreCompletoOcup { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public DateOnly? FechaVcmto { get; set; }

    public DateOnly? FechaCorte { get; set; }
}
