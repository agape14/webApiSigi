using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TActoAnulacion
{
    public int CodActoAnulacion { get; set; }

    public int? CodActo { get; set; }

    public string? DocAprob { get; set; }

    public string? NumDocAprob { get; set; }

    public DateOnly? FecDocAprob { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecFin { get; set; }

    public string? FinGen { get; set; }

    public string? FinEsp { get; set; }

    public int? CodInsp { get; set; }

    public string? Condiciones { get; set; }

    public int? CodActoFin { get; set; }

    public string? TipoInmueble { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public int? TipoActo { get; set; }

    public string? Administrado { get; set; }

    public int? ActoConclu { get; set; }

    public DateOnly? FechaConclu { get; set; }

    public string? TipoBeneficiario { get; set; }

    public int? CodActoAnterior { get; set; }

    public string? Estado { get; set; }

    public int? CodContrato { get; set; }

    public string? DocConclu { get; set; }

    public string? CausalesConclu { get; set; }

    public int? CodInspConclu { get; set; }

    public string? Observaciones { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public DateOnly? FecAprobGg { get; set; }

    public int? Cumx { get; set; }

    public int? NroNotificacion { get; set; }

    public int? NroMeses { get; set; }
}
