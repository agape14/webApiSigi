using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TContratoAnulacion
{
    public int CodContratoAnulacion { get; set; }

    public int? CodContrato { get; set; }

    public int? NumContrato { get; set; }

    public int? Adenda { get; set; }

    public int Cum { get; set; }

    public int? Cuim { get; set; }

    public string? Tipo { get; set; }

    public string? Modalidad { get; set; }

    public int? CodSubasta { get; set; }

    public string? TipoComprobante { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Renta { get; set; }

    public decimal? GarantiaOblig { get; set; }

    public decimal? GarantiaReal { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Penalidad { get; set; }

    public string? SociedadConyugal { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecFin { get; set; }

    public string? UsoGen { get; set; }

    public string? UsoEsp { get; set; }

    public string? Restric { get; set; }

    public string? Obligaciones { get; set; }

    public string? CausalesResolucion { get; set; }

    public string? NotificaVencim { get; set; }

    public DateOnly? FecEntregaNotifVencim { get; set; }

    public string? NotificaVencimDoc { get; set; }

    public string? RespNotificacion { get; set; }

    public DateOnly? FecRespNotificacion { get; set; }

    public string? RespNotificacionDoc { get; set; }

    public string? DeseaRenovar { get; set; }

    public string? ComunicaResolucion { get; set; }

    public DateOnly? FecComunicaResolucion { get; set; }

    public string? ComunicaResolucionDoc { get; set; }

    public string? SolicitaConciliacion { get; set; }

    public DateOnly? FecSolicitaConciliacion { get; set; }

    public string? SolicitaConciliacionDoc { get; set; }

    public string? ResulConciliacion { get; set; }

    public string? Conclusion { get; set; }

    public decimal? TasaInteres { get; set; }

    public string? RentaAdelantada { get; set; }

    public string? OperPagoRenta { get; set; }

    public string? CopiaPoder { get; set; }

    public int? CopiaPoderAntiguedad { get; set; }

    public string? DjArrend { get; set; }

    public string? CopiaDniarrend { get; set; }

    public string? FiadorNombCompl { get; set; }

    public string? FiadorDni { get; set; }

    public string? FiadorDomicilio { get; set; }

    public string? FiadorEmail { get; set; }

    public string? FiadorTelefono { get; set; }

    public string? FiadorMovil { get; set; }

    public string? DjFiador { get; set; }

    public string? CopiaDnifiador { get; set; }

    public string? Infocor { get; set; }

    public string? FichaRegPropFiador { get; set; }

    public string? LetraCambio { get; set; }

    public decimal? ValorLetraCambio { get; set; }

    public string? DerivadoOgaf { get; set; }

    public string? DerivadoOgafdoc { get; set; }

    public DateOnly? FecDerivadoOgaf { get; set; }

    public string? CumplePagoRentaPunt { get; set; }

    public string? CumpleNoDeter { get; set; }

    public string? CumpleNoSubarrend { get; set; }

    public string? CumplePagoServ { get; set; }

    public string? CumplePagoArbitr { get; set; }

    public DateOnly? FecCesion { get; set; }

    public decimal? PenalidadCesion { get; set; }

    public string? Justificacion { get; set; }

    public int? CodContratoNuevo { get; set; }

    public string? NumContratoNuevo { get; set; }

    public string? CesionarioDni { get; set; }

    public string? CesionarioNomb { get; set; }

    public string? UsoDiferente { get; set; }

    public string? IncumpleRenta { get; set; }

    public string? IncumpleArbitrio { get; set; }

    public string? IncumpleServ { get; set; }

    public string? SubArrend { get; set; }

    public string? ModifSinConsect { get; set; }

    public string? UsoDeposito { get; set; }

    public string? ReqProyMuni { get; set; }

    public string? Fallece { get; set; }

    public string? IncumpleReposGarant { get; set; }

    public string? Unilateral { get; set; }

    public string? Inhabitable { get; set; }

    public string? EstadoResolCont { get; set; }

    public string? TipoArrendatario { get; set; }

    public DateOnly? FecActaConciliacion { get; set; }

    public string? ActaConciliacionDoc { get; set; }

    public string? AptoRenovacion { get; set; }

    public string? AccionesLegales { get; set; }

    public decimal? VariacionPorc { get; set; }

    public DateOnly? FecReprogramacion { get; set; }

    public string? DocReprogramacion { get; set; }

    public int? RentaCodConcepto { get; set; }

    public string? ContratoFirmado { get; set; }

    public string? DatosCobranza { get; set; }

    public int? Reprogramaciones { get; set; }

    public string? EstContrato { get; set; }

    public string? NumContratoFisico { get; set; }

    public string? Ocupantes { get; set; }

    public string? ResponsablePagoAgua { get; set; }

    public string? ResponsablePagoLuz { get; set; }

    public string? ResponsablePagoArbitrios { get; set; }

    public string? ResponsablePagoImpPredial { get; set; }

    public decimal? RentaPropuestaRenovacion { get; set; }

    public decimal? GarantiaPropuestaRenovacion { get; set; }

    public string? PagoReajusteGarantia { get; set; }

    public int? CodPcontReajusteGarantia { get; set; }

    public string? DocumentoPagoReajusteGarantia { get; set; }

    public int? NumCartaCobranza { get; set; }

    public string? FiadorTipoPersona { get; set; }

    public string? Fiador2TipoPersona { get; set; }

    public string? Fiador2NombCompl { get; set; }

    public string? Fiador2Dni { get; set; }

    public string? Fiador2Domicilio { get; set; }

    public string? Fiador2Email { get; set; }

    public string? Fiador2Telefono { get; set; }

    public string? Fiador2Movil { get; set; }

    public string? DjFiador2 { get; set; }

    public string? CopiaDnifiador2 { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? Cumx { get; set; }

    public string? MotivoAnulacion { get; set; }

    public string? UsuarioAnulacion { get; set; }

    public DateOnly? FechaAnulacion { get; set; }
}
