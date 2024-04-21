using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TSubastaInmueble
{
    public int CodSubInm { get; set; }

    public int? CodSubasta { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public decimal? RentaPropuesta { get; set; }

    public decimal? RentaBase { get; set; }

    public string? FichaTecnica { get; set; }

    public decimal? ValRef { get; set; }

    public string? PartReg { get; set; }

    public string? TieneProcJud { get; set; }

    public string? Observaciones { get; set; }

    public string? AdjudicaDoc { get; set; }

    public string? InformeJudicial { get; set; }

    public string? Via { get; set; }

    public string? Distrito { get; set; }

    public decimal? Area { get; set; }

    public string? Estado { get; set; }

    public decimal? ValorAdjudicado { get; set; }

    public decimal? GarantiaCalculada { get; set; }

    public string? Adjudicado { get; set; }

    public decimal? GarantiaBase { get; set; }

    public int? CodPostor { get; set; }

    public string? Numero { get; set; }

    public string? Participantes { get; set; }

    public int? CodComprob { get; set; }

    public string? DocumentoPago { get; set; }

    public int? Ticket { get; set; }

    public int? Mes { get; set; }

    public string? Pagado { get; set; }

    public string? DescPredio { get; set; }

    public int? CodPostorAnterior { get; set; }

    public string? ParticipantesAnterior { get; set; }

    public int? CodComprobAnterior { get; set; }

    public string? DocumentoPagoAnterior { get; set; }

    public int? TicketAnterior { get; set; }

    public int? MesAnterior { get; set; }

    public string? PagadoAnterior { get; set; }

    public decimal? ValorAdjudicadoAnterior { get; set; }

    public decimal? GarantiaCalculadaAnterior { get; set; }

    public decimal? ImporteInscripcionPostor { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
