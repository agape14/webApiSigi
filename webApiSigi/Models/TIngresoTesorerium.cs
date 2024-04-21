using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TIngresoTesorerium
{
    public int CodIngreso { get; set; }

    public int CodComprob { get; set; }

    public int? CodConcepto { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Canal { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Igv { get; set; }

    public decimal? Total { get; set; }

    public string? EstIngreso { get; set; }

    public string? Detalle { get; set; }

    public int? CodPla { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Intereses { get; set; }

    public string? CodRefer { get; set; }

    public string? Serie { get; set; }

    public string? Numero { get; set; }

    public string? Documento { get; set; }

    public int? Item { get; set; }

    public string? PendientePago { get; set; }

    public string? PagoPendiente { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public string? AfectoIgv { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Preciounit { get; set; }

    public decimal? TotalExonerado { get; set; }
}
