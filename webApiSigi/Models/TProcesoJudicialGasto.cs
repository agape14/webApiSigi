using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicialGasto
{
    public int CodPjg { get; set; }

    public int? CodPj { get; set; }

    public DateOnly? FecGasto { get; set; }

    public int? Mes { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Importe { get; set; }

    public string? Documento { get; set; }

    public string? TipoGasto { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
