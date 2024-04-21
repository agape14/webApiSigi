using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TPostorSubastum
{
    public int CodPostor { get; set; }

    public int? CodSubasta { get; set; }

    public string? TipoPostor { get; set; }

    public decimal? Deposito { get; set; }

    public string? Admitido { get; set; }

    public string? MotivoNoAdmitido { get; set; }

    public string? AdquirioBase { get; set; }

    public decimal? Oferta { get; set; }

    public string? Participantes { get; set; }

    public string? Estado { get; set; }

    public int? CodComprobBase { get; set; }

    public int? CodComprobInscripcion { get; set; }

    public decimal? ImporteBase { get; set; }

    public decimal? ImporteInscripcion { get; set; }

    public string? ImpBasePagado { get; set; }

    public string? ImpInscripcionPagado { get; set; }

    public int? TicketBase { get; set; }

    public int? TicketInscripcion { get; set; }

    public string? DocumentoPagoBase { get; set; }

    public string? DocumentoPagoInscripcion { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? SetTicketMes { get; set; }

    public int? SetTicketAnio { get; set; }
}
