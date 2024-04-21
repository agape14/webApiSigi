using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TExportaBancoCab
{
    public int CodEbanco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? TipoValidacion { get; set; }

    public string? NomEmpresa { get; set; }

    public string? FecTransmision { get; set; }

    public string? CantTotReg { get; set; }

    public string? MontoTotEnv { get; set; }

    public string? TipoArchivo { get; set; }

    public string? Filler { get; set; }

    public decimal? MontoTotEnvD { get; set; }

    public string? EstExpBanco { get; set; }

    public decimal? CantTotRegD { get; set; }

    public string? OperacionEnvio { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
