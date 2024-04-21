using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TMovimientoContable
{
    public int CodMovCont { get; set; }

    public int? CodIngreso { get; set; }

    public string? Cuenta { get; set; }

    public decimal? Debito { get; set; }

    public decimal? Credito { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Concepto { get; set; }

    public string? Tipo { get; set; }

    public string? TipoComprobOrigen { get; set; }

    public string? NumComprobOrigen { get; set; }

    public decimal? TipoCambio { get; set; }

    public string? TipoDocComprob { get; set; }

    public string? NumDocComprob { get; set; }

    public DateOnly? FechaVenc { get; set; }

    public string? CodCliProv { get; set; }

    public string? Moneda { get; set; }

    public string? TipoDebeHaber { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Igv { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Glosa { get; set; }

    public string? Libro { get; set; }

    public int? CorrelativoOrigen { get; set; }

    public string? Exportado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
