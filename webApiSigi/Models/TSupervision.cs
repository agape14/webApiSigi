using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TSupervision
{
    public int CodSup { get; set; }

    public string? NumInspDoc { get; set; }

    public int? Cum { get; set; }

    public DateOnly? FecInsp { get; set; }

    public DateOnly? FecInspVig { get; set; }

    public string? InspOcupado { get; set; }

    public string? InspLuz { get; set; }

    public string? InspAgua { get; set; }

    public string? InspPiso { get; set; }

    public string? InspTecho { get; set; }

    public string? InspParedes { get; set; }

    public string? InspPuertas { get; set; }

    public string? InspObserv { get; set; }

    public string? InspResponsable { get; set; }

    public decimal? InspArea { get; set; }

    public string? InspConformidad { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
