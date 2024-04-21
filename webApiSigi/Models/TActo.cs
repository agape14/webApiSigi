using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TActo
{
    public int CodActo { get; set; }

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

    public int? MotivoActo { get; set; }

    public string? SolicitudArrendamiento { get; set; }

    public DateOnly? FecSolicitud { get; set; }

    public string? AcuerdoDirectorio { get; set; }

    public string? NumeroAcuerdo { get; set; }

    public DateOnly? FecAcuerdo { get; set; }

    public string? PropTecnEconomica { get; set; }

    public DateOnly? FecPropuesta { get; set; }

    public string? InformeAlcance { get; set; }

    public string? NumeroInformeAlcance { get; set; }

    public DateOnly? FecInforme { get; set; }

    public string? ActaEntrega { get; set; }

    public DateOnly? FecActaEntrega { get; set; }

    public string? SolicitudAcuerdoDirec { get; set; }

    public string? NumeroAcuerdoDirec { get; set; }

    public DateOnly? FecAcuerdoDirec { get; set; }

    public string? SolicitudArrendamientoSc { get; set; }

    public DateOnly? FecSolicitudSc { get; set; }
}
