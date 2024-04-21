using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TPlanillaDeposito
{
    public int CodDepPla { get; set; }

    public int CodPla { get; set; }

    public DateOnly? FecDep { get; set; }

    public string? Canal { get; set; }

    public string? Codigo { get; set; }

    public decimal? Importe { get; set; }

    public string? EstDeposito { get; set; }

    public int? CodBanco { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    /// <summary>
    /// serie del comprobante relacionado
    /// </summary>
    public string? SerieRel { get; set; }

    /// <summary>
    /// numero del comprobante relacionado
    /// </summary>
    public string? NumeroRel { get; set; }
}
