using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class VInfocorp
{
    public long? CodExpIdet { get; set; }

    public DateTime FechaReporte { get; set; }

    public string? CodigoEntidad { get; set; }

    public string CodPersona { get; set; } = null!;

    public string DocumentoCredito { get; set; } = null!;

    public string? TipoDoc { get; set; }

    public string NumDoc { get; set; } = null!;

    public string? TipoPersona { get; set; }

    public string TipoDeudor { get; set; } = null!;

    public string? NombreDeudor { get; set; }

    public string? DomicilioDeudor { get; set; }

    public string? DistritoDeudor { get; set; }

    public string? DepartamentoDeudor { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string AdicionalDocCredito { get; set; } = null!;

    public string Moneda { get; set; } = null!;

    public decimal? Deuda { get; set; }

    public string CondicionDocMoroso { get; set; } = null!;
}
