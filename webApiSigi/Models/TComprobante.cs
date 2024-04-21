using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TComprobante
{
    public int CodComprob { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public string? Tipo { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public string? CodPersona { get; set; }

    public string? NombreCompletoSunat { get; set; }

    public string? DireccionSunat { get; set; }

    public string? Ruc { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Igv { get; set; }

    public decimal? Total { get; set; }

    public string? EstComprob { get; set; }

    public string? TipoDoc { get; set; }

    public string? Emitido { get; set; }

    public string? Generado { get; set; }

    public DateOnly? FechaVenc { get; set; }

    public string? TipoComprobOrigen { get; set; }

    public int? NumComprobOrigen { get; set; }

    public int? Ticket { get; set; }

    public DateOnly? TicketCreado { get; set; }

    public string? TicketValido { get; set; }

    public DateTime? TicketVence { get; set; }

    public int? Mes { get; set; }

    public int? Voucher { get; set; }

    public string? PagoPendiente { get; set; }

    public int? TicketMes { get; set; }

    public int? TicketAnio { get; set; }

    public string? Origen { get; set; }

    public DateOnly? FechaResumen { get; set; }

    public string? MetodoPago { get; set; }

    public string? SerieComprobOrigen { get; set; }

    public string? FacturaElectronica { get; set; }

    public string? TipoMaterial { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public string? HoraComprobante { get; set; }

    public string? TipoNota { get; set; }

    public string? MotivoNota { get; set; }

    public int? TicketAutorizado { get; set; }

    public int? IdPedido { get; set; }

    public int? Cantidad { get; set; }
}
