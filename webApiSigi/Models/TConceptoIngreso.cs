using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TConceptoIngreso
{
    public int CodConcepto { get; set; }

    public string? Nombre { get; set; }

    public string? Estado { get; set; }

    public string? Tipo { get; set; }

    public string? CcVentas { get; set; }

    public string? CcVentasImpuesto { get; set; }

    public string? CcRemTransito { get; set; }

    public string? CcRemTransitoDetrac { get; set; }

    public string? Clase { get; set; }

    public string? CcCuentasPorCobrar { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
