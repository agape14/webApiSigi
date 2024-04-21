using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class VMargesiAmpliadoDetallado
{
    public int? Cum { get; set; }

    public int? Cuim { get; set; }

    public string? TipInmueble { get; set; }

    public string? TipInmuebleNombre { get; set; }

    public string? Denominacion { get; set; }

    public string? DescPredio { get; set; }

    public string? Direccion { get; set; }

    public string? Dist { get; set; }

    public string? NombreDistrito { get; set; }

    public string? TipHabilita { get; set; }

    public string? TipHabilitaNombre { get; set; }

    public string? NomHabilita { get; set; }

    public string? TipVia { get; set; }

    public string? TipViaNombre { get; set; }

    public string? NomVia { get; set; }

    public string? NumMuni { get; set; }

    public string? NumInterno { get; set; }

    public string? AreaReg { get; set; }

    public decimal? AreaTotal { get; set; }

    public string? FormaAdqui { get; set; }

    public string? FormaAdquiNombre { get; set; }

    public string? TipDom { get; set; }

    public string? TipDomNombre { get; set; }

    public string? TipBienCul { get; set; }

    public string? TipBienCulNombre { get; set; }

    public string? TipInterv { get; set; }

    public string? TipIntervNombre { get; set; }

    public string? TipEdif { get; set; }

    public string? TipEdifNombre { get; set; }

    public string? EstConserv { get; set; }

    public string? EstConservNombre { get; set; }

    public decimal? ValTerr { get; set; }

    public decimal? ValEdif { get; set; }

    public decimal? ValTot { get; set; }

    public decimal? ValM2 { get; set; }

    public decimal? ValArrendMes { get; set; }

    public DateOnly? FecValoriza { get; set; }

    public string? NumeroAgua { get; set; }

    public string? NumeroLuz { get; set; }

    public string? EmpresaAgua { get; set; }

    public string? EmpresaLuz { get; set; }

    public string? UsoGenInmueble { get; set; }

    public string? UsoGenInmuebleNombre { get; set; }

    public string? UsoEspInmueble { get; set; }

    public string? UsoEspInmuebleNombre { get; set; }

    public int? CuotasDeudaLuz { get; set; }

    public int? CuotasDeudaAgua { get; set; }

    public int? CuotasDeudaPredial { get; set; }

    public int? CuotasDeudaArbitrios { get; set; }

    public DateOnly? FecInicioActo { get; set; }

    public DateOnly? FecFinActo { get; set; }

    public string? FinGenActo { get; set; }

    public string? FinGenActoNombre { get; set; }

    public string? FinEspActo { get; set; }

    public string? FinEspActoNombre { get; set; }

    public int? TipoActo { get; set; }

    public string? TipoActoNombre { get; set; }

    public string? TipoBeneficiario { get; set; }

    public string? TipoBeneficiarioNombre { get; set; }

    public string? AdministradoActo { get; set; }

    public string? EstadoActo { get; set; }

    public string? EstadoActoNombre { get; set; }

    public int? CodContrato { get; set; }

    public int? NumContrato { get; set; }

    public int? Adenda { get; set; }

    public string? NumContratoFisico { get; set; }

    public string? TipoArrendatario { get; set; }

    public string? Ocupantes { get; set; }

    public DateOnly? FecInicioContrato { get; set; }

    public DateOnly? FecFinContrato { get; set; }

    public string? UsoGenContrato { get; set; }

    public string? UsoGenContratoNombre { get; set; }

    public string? UsoEspContrato { get; set; }

    public string? UsoEspContratoNombre { get; set; }

    public decimal? Renta { get; set; }

    public decimal? GarantiaOblig { get; set; }

    public decimal? GarantiaReal { get; set; }

    public int? NumCuota { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? InteresAcumulado { get; set; }

    public decimal? TotalDeuda { get; set; }

    public string? ResponsablePagoAgua { get; set; }

    public string? ResponsablePagoLuz { get; set; }

    public string? ResponsablePagoArbitrios { get; set; }

    public string? ResponsablePagoImpPredial { get; set; }

    public int? CodSubasta { get; set; }

    public string? NumDocSubasta { get; set; }

    public DateOnly? FecSolicSub { get; set; }

    public DateOnly? FecAprobSub { get; set; }

    public string? SubaLugar { get; set; }

    public string? EstadoSubasta { get; set; }

    public string? EstadoSubastaNombre { get; set; }

    public DateTime? SubaDiaHora { get; set; }

    public int? NumSubasta { get; set; }

    public decimal? RentaBase { get; set; }

    public string? EstadoInmuebleSubasta { get; set; }

    public string? EstadoInmuebleSubastaNombre { get; set; }

    public decimal? ValorAdjudicado { get; set; }

    public decimal? GarantiaCalculada { get; set; }

    public int? CodPostor { get; set; }

    public int? CodComprob { get; set; }

    public string? DocumentoPago { get; set; }

    public string? TipoPostor { get; set; }

    public string? Participantes { get; set; }

    public string? EstadoPostor { get; set; }

    public decimal? ImporteInscripcion { get; set; }

    public string? ImpBasePagado { get; set; }

    public string? ImpInscripcionPagado { get; set; }

    public string? DocumentoPagoBase { get; set; }

    public string? DocumentoPagoInscripcion { get; set; }
}
