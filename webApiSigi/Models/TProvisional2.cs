using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TProvisional2
{
    public int CodProv { get; set; }

    public string? Denominacion { get; set; }

    public DateOnly? FecReg { get; set; }

    public string? EstReg { get; set; }

    public string? TipInmueble { get; set; }

    public string? TipUnidad { get; set; }

    public string? SitFisLeg { get; set; }

    public string? DetFisLeg { get; set; }

    public string? RegRel { get; set; }

    public string? DescPredio { get; set; }

    public string? TipHabilita { get; set; }

    public string? NomHabilita { get; set; }

    public string? TipVia { get; set; }

    public string? NomVia { get; set; }

    public string? NumMuni { get; set; }

    public string? NumInterno { get; set; }

    public string? Manzana { get; set; }

    public string? Lote { get; set; }

    public string? Direccion { get; set; }

    public string? Dpto { get; set; }

    public string? Prov { get; set; }

    public string? Dist { get; set; }

    public decimal? Altitud { get; set; }

    public decimal? Latitud { get; set; }

    public string? FormaAdqui { get; set; }

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

    public string? TipBienCul { get; set; }

    public string? Resol { get; set; }

    public string? Mizona { get; set; }

    public string? TipInterv { get; set; }

    public string? ProyInflu { get; set; }

    public string? TraDecla { get; set; }

    public string? TieneCarga { get; set; }

    public DateOnly? FecInsp { get; set; }

    public string? CodCatast { get; set; }

    public string? Zonif { get; set; }

    public decimal? AreaLibre { get; set; }

    public decimal? AreaConst { get; set; }

    public decimal? AreaTotal { get; set; }

    public string? Topografia { get; set; }

    public string? TipoSuelo { get; set; }

    public string? TipoPredio { get; set; }

    public string? DetTipoPredio { get; set; }

    public string? OtraInfo { get; set; }

    public string? NivUso { get; set; }

    public string? UsoGen { get; set; }

    public string? UsoEsp { get; set; }

    public string? TipEdif { get; set; }

    public int? NumPisos { get; set; }

    public int? MesConst { get; set; }

    public int? AnioConst { get; set; }

    public string? MatConst { get; set; }

    public string? EstConserv { get; set; }

    public string? Muro { get; set; }

    public string? Techo { get; set; }

    public string? Pisos { get; set; }

    public string? Puertas { get; set; }

    public string? Revest { get; set; }

    public string? Banio { get; set; }

    public string? ServAgua { get; set; }

    public string? FactServAgua { get; set; }

    public string? ServDesag { get; set; }

    public string? FactServDesag { get; set; }

    public string? ServLuz { get; set; }

    public string? FactServLuz { get; set; }

    public string? ServCable { get; set; }

    public string? ServInternet { get; set; }

    public string? ObsTecnicas { get; set; }

    public string? ValMoneda { get; set; }

    public decimal? TipoCambio { get; set; }

    public decimal? ValTerr { get; set; }

    public decimal? ValEdif { get; set; }

    public decimal? ValTot { get; set; }

    public decimal? ValM2 { get; set; }

    public decimal? ValArrendMes { get; set; }

    public DateOnly? FecValoriza { get; set; }

    public string? InformeVal { get; set; }

    public string? FreColReg { get; set; }

    public int? FreTramo { get; set; }

    public string? FreDistancia { get; set; }

    public string? FreNumMunicipal { get; set; }

    public string? DerColReg { get; set; }

    public int? DerTramo { get; set; }

    public string? DerDistancia { get; set; }

    public string? DerNumMunicipal { get; set; }

    public string? IzqColReg { get; set; }

    public int? IzqTramo { get; set; }

    public string? IzqDistancia { get; set; }

    public string? IzqNumMunicipal { get; set; }

    public string? FonColReg { get; set; }

    public int? FonTramo { get; set; }

    public string? FonDistancia { get; set; }

    public string? FonNumMunicipal { get; set; }

    public string? RefTipoVia { get; set; }

    public string? RefNomVia { get; set; }

    public decimal? RefProxEsquina { get; set; }

    public string? RefProxOrient { get; set; }

    public string? RefProxNomVia { get; set; }

    public decimal? RefViaPrincDist { get; set; }

    public string? RefViaPrincOrient { get; set; }

    public string? RefViaPrincNomVia { get; set; }

    public string? CalidadOcup { get; set; }

    public string? TipoDocOcup { get; set; }

    public string? NumDocOcup { get; set; }

    public string? Ocupante { get; set; }

    public string? ObsLegales { get; set; }

    public double? ValEdifEstimado { get; set; }

    public int? CodItl { get; set; }

    public int? NumItl { get; set; }

    public string? NumItldocumento { get; set; }

    public DateTime? FecItl { get; set; }

    public string? Remitente { get; set; }

    public string? Destinatario { get; set; }

    public string? Asunto { get; set; }

    public string? ItlConclusion { get; set; }

    public string? OtraInformacion { get; set; }

    public string? Numero { get; set; }

    public string? FreLindero { get; set; }

    public string? DerLindero { get; set; }

    public string? IzqLindero { get; set; }

    public string? FonLindero { get; set; }

    public decimal? Zona { get; set; }

    public decimal? Abcisa { get; set; }

    public decimal? Norte { get; set; }

    public string? EdifDetalle { get; set; }

    public string? ZonifDetalle { get; set; }

    public string? FormaAdquiDetalle { get; set; }

    public string? Independizado { get; set; }

    public string? PuertaCalle { get; set; }

    public string? NivOcup { get; set; }

    public string? OcupUi { get; set; }

    public decimal? AreaOcupUi { get; set; }

    public string? Ocup { get; set; }

    public double? AreaOcup { get; set; }

    public int? AntiguedadOcup { get; set; }

    public DateOnly? DesdeOcup { get; set; }

    public DateOnly? HastaOcup { get; set; }

    public string? NumeroAgua { get; set; }

    public string? NumeroLuz { get; set; }

    public decimal? ValTotDolares { get; set; }

    public int? UsoMesesGarantia { get; set; }

    public string? EmpresaAgua { get; set; }

    public string? EmpresaLuz { get; set; }

    public string? DocFotos { get; set; }

    public string? RemitenteNombre { get; set; }

    public string? DestinatarioNombre { get; set; }

    public string? Referencias { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
