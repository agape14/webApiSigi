using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TUnidadInmobiliariaEdificacion
{
    public int CodEdifUi { get; set; }

    public int? CodProv { get; set; }

    public int? CodUiprov { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public string? Piso { get; set; }

    public decimal? Muro { get; set; }

    public decimal? Techo { get; set; }

    public decimal? Pisos { get; set; }

    public decimal? Puertas { get; set; }

    public decimal? Revest { get; set; }

    public decimal? Banio { get; set; }

    public decimal? AreaConstVerif { get; set; }

    public decimal? ValEdifEstimado { get; set; }

    public int? NumPiso { get; set; }

    public decimal? TotalValor { get; set; }

    public decimal? InstElectricas { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
