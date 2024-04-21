using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TExportaContaDetSimula
{
    public int CodEcontaD { get; set; }

    public int? CodEconta { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoOrigen { get; set; }

    public string? NumOrigen { get; set; }

    public string? FecComprobante { get; set; }

    public string? CuentaContable { get; set; }

    public string? Monto { get; set; }

    public string? CargaDebeHaber { get; set; }

    public string? Moneda { get; set; }

    public string? TipoCambio { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumDocumento { get; set; }

    public string? FecVencimiento { get; set; }

    public string? CodProvCli { get; set; }

    public string? CentroCosto { get; set; }

    public string? FlujoEfectivo { get; set; }

    public string? Presupuesto { get; set; }

    public string? FecDocumento { get; set; }

    public string? MontoNeto1Libro { get; set; }

    public string? MontoNeto2 { get; set; }

    public string? MontoNeto3 { get; set; }

    public string? MontoNeto4 { get; set; }

    public string? MontoIgv { get; set; }

    public string? RucProvCli { get; set; }

    public string? RazonSocial { get; set; }

    public string? Glosa { get; set; }

    public string? TipoDni { get; set; }

    public string? MedioPago { get; set; }

    public string? ApePaterno { get; set; }

    public string? ApeMaterno { get; set; }

    public string? Nombres { get; set; }

    public string? MontoNeto5 { get; set; }

    public string? MontoNeto6 { get; set; }

    public string? RefNumero { get; set; }

    public string? RefTipoDoc { get; set; }

    public string? RefFecha { get; set; }

    public string? DetraccionNum { get; set; }

    public string? DetraccionFec { get; set; }

    public string? TipoLibro { get; set; }

    public string? TipoProvCli { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
