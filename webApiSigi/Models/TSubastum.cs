using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TSubastum
{
    public int CodSubasta { get; set; }

    public string? NumDocSubasta { get; set; }

    public int? CodActo { get; set; }

    public string? TipoSubasta { get; set; }

    public string? Modalidad { get; set; }

    public decimal? Comision { get; set; }

    public string? TipoPuja { get; set; }

    public decimal? ValorPuja { get; set; }

    public DateOnly? FecSolicSub { get; set; }

    public DateOnly? FecAprobSub { get; set; }

    public DateOnly? BaseInicio { get; set; }

    public DateOnly? BaseFin { get; set; }

    public string? BaseLugar { get; set; }

    public DateOnly? InscInicio { get; set; }

    public DateOnly? InscFin { get; set; }

    public string? InscLugar { get; set; }

    public DateOnly? SubaFecha { get; set; }

    public TimeOnly? SubaHora { get; set; }

    public string? SubaLugar { get; set; }

    public decimal? PrecioBases { get; set; }

    public string? ComitePresDni { get; set; }

    public string? ComitePresNomb { get; set; }

    public string? ComiteTitular1Dni { get; set; }

    public string? ComiteTitular1Nomb { get; set; }

    public string? ComiteTitular2Dni { get; set; }

    public string? ComiteTitular2Nomb { get; set; }

    public string? ComiteSuplenteNomb { get; set; }

    public string? VeedorOcidni { get; set; }

    public string? VeedorOcinomb { get; set; }

    public string? DocAprobSub { get; set; }

    public string? Estado { get; set; }

    public string? TieneComision { get; set; }

    public string? DocAprobacion { get; set; }

    public DateOnly? FechaInformeSustento { get; set; }

    public string? InformeSustento { get; set; }

    public DateOnly? FechaOpinionLegal { get; set; }

    public string? OpinionLegal { get; set; }

    public DateOnly? FechaBases { get; set; }

    public string? Bases { get; set; }

    public DateOnly? FechaResolucion { get; set; }

    public string? Resolucion { get; set; }

    public string? ComiteSuplenteDni { get; set; }

    public string? ConfComite { get; set; }

    public DateOnly? FechaActaAdjudicacion { get; set; }

    public string? ActaAdjudicacion { get; set; }

    public string? DocAprobComite { get; set; }

    public decimal? ImporteBase { get; set; }

    public decimal? ImporteInscripcion { get; set; }

    public DateOnly? FecConvoca { get; set; }

    public DateOnly? FecConsultas { get; set; }

    public DateOnly? FecCancelaMontoOfertado { get; set; }

    public DateOnly? FecContrato { get; set; }

    public DateOnly? FecConsultasEscrito { get; set; }

    public DateTime? SubaDiaHora { get; set; }

    public int? NumSubasta { get; set; }

    public DateOnly? FechaInformeAdjudicacion { get; set; }

    public string? InformeAdjudicacion { get; set; }

    public int? CodOl { get; set; }

    public string? EstSustento { get; set; }

    public string? ObservSustento { get; set; }

    public string? ResultadoOl { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? NumConvocatoria { get; set; }

    public string? CodEntAdmin { get; set; }

    public string? Anio { get; set; }
}
