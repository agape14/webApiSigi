using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProcesoJudicial
{
    public int CodPj { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecFin { get; set; }

    public string? NumExpediente { get; set; }

    public string? Materia { get; set; }

    public string? EstPj { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public string? CodDemandante { get; set; }

    public string? NomDemandante { get; set; }

    public string? CodDemandado { get; set; }

    public string? NomDemandado { get; set; }

    public string? DireccionInmueble { get; set; }

    public decimal? Monto { get; set; }

    public string? Moneda { get; set; }

    public DateOnly? FecLanzamiento { get; set; }

    public DateOnly? FecSolicitado { get; set; }

    public string? TipoProceso { get; set; }

    public string? CodEntidad { get; set; }

    public string? CodJuzgado { get; set; }

    public DateOnly? FecDesestimiento { get; set; }

    public DateOnly? FecDemanda { get; set; }

    public DateOnly? FecEmplaza { get; set; }

    public string? NotiEmplaza { get; set; }

    public DateOnly? FecProbatoria { get; set; }

    public string? NotiProbatoria { get; set; }

    public DateOnly? FecSentencia { get; set; }

    public string? NotiSentencia { get; set; }

    public DateOnly? FecApelacion { get; set; }

    public string? NotiApelacion { get; set; }

    public DateOnly? FecVistaCausa { get; set; }

    public string? NotiVistaCausa { get; set; }

    public DateOnly? FecSentenciaVista { get; set; }

    public string? NotiSentenciaVista { get; set; }

    public DateOnly? FecIniEvaluacion { get; set; }

    public string? CodEtapa { get; set; }

    public DateOnly? FecDecision { get; set; }

    public string? Decision { get; set; }

    public string? MotivosDecision { get; set; }

    public DateOnly? FecRecibido { get; set; }

    public string? MateriaDetalle { get; set; }

    public DateOnly? FecInstalacion { get; set; }

    public string? NumEtapa { get; set; }

    public string? TipoProcesoNombre { get; set; }

    public string? MateriaNombre { get; set; }

    public string? EstPjnombre { get; set; }

    public string? CodEtapaNombre { get; set; }

    public string? Recuperado { get; set; }

    public decimal? MontoRecuperado { get; set; }

    public DateOnly? FecMontoRecuperado { get; set; }

    public string? MedidaCautelar { get; set; }

    public string? Instancia { get; set; }

    public string? Juzgado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }
}
