using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TItl
{
    public int CodItl { get; set; }

    public int? NumItl { get; set; }

    public string? NumItldocumento { get; set; }

    public DateOnly? FecItl { get; set; }

    public string? Remitente { get; set; }

    public string? RemitenteNombre { get; set; }

    public string? Destinatario { get; set; }

    public string? DestinatarioNombre { get; set; }

    public string? Asunto { get; set; }

    public string? TipoItl { get; set; }

    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public int? CodProv { get; set; }

    public string? ItlConclusion { get; set; }

    public string? Area { get; set; }

    public int? CodActo { get; set; }

    public int? TipoActo { get; set; }

    public string? Estado { get; set; }

    public string? Derivado { get; set; }

    public string? DerivadoNombre { get; set; }

    public string? Referencias { get; set; }

    public string? Adjuntos { get; set; }

    public string? NombreAnio { get; set; }

    public string? Creado { get; set; }

    public string? FormaAdqui { get; set; }

    public string? FormaAdquiDetalle { get; set; }

    public string? TituloLeg { get; set; }

    public string? DispLeg { get; set; }

    public string? InscReg { get; set; }

    public DateOnly? InscFec { get; set; }

    public string? TomoFoja { get; set; }

    public string? FichaReg { get; set; }

    public string? PartidaElect { get; set; }

    public string? TitularReg { get; set; }

    public string? AreaReg { get; set; }

    public string? FabInsc { get; set; }

    public DateOnly? FecFab { get; set; }

    public string? TipDom { get; set; }

    public string? EntAdm { get; set; }

    public string? ObsLegales { get; set; }

    public string? DocOpinionLegal { get; set; }

    public string? OpinionLegal { get; set; }

    public int? CodOl { get; set; }

    public string? Observaciones { get; set; }

    public string? RemitenteCompleto { get; set; }

    public string? DestinatarioCompleto { get; set; }

    public DateOnly? FecAprobItl { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }

    public string? ObservacionesProv { get; set; }

    public string? EstadoActoProv { get; set; }

    public DateOnly? FecAprobacionProv { get; set; }

    public string? NumDocAprobProv { get; set; }

    public string? DocAprobProv { get; set; }

    public DateOnly? FecAprobGgprov { get; set; }

    public string? DocAprobProvGg { get; set; }

    public string? NumDocAprobProvGg { get; set; }

    public string? AntecedentesCaso { get; set; }

    public string? CodVerficacion { get; set; }
}
