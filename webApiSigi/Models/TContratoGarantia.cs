using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TContratoGarantia
{
    public int CodGcont { get; set; }

    public int CodContrato { get; set; }

    public decimal? Importe { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Motivo { get; set; }

    public string? DocAprobacion { get; set; }

    public string? EstGarantia { get; set; }

    public decimal? GarantiaOblig { get; set; }

    public decimal? GarantiaReal { get; set; }

    public int? CodPcont { get; set; }

    public string? Informe { get; set; }

    public string? OpinionLegal { get; set; }

    public int? CodOl { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public string? EjecutoTicketG { get; set; }
}
