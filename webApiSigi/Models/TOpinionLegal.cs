using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TOpinionLegal
{
    public int CodOl { get; set; }

    public string? Titulo { get; set; }

    public string? Archivo { get; set; }

    public string? EstOpinion { get; set; }

    public DateOnly? FecOpinion { get; set; }

    public int? Codigo { get; set; }

    public string? Tipo { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public DateOnly? FecSolicitado { get; set; }

    public DateOnly? FecRecibido { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
