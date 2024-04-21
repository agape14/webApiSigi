using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TImportaBancoCab
{
    public int CodIbanco { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? TipoValidacion { get; set; }

    public string? FecProceso { get; set; }

    public string? CantTotReg { get; set; }

    public string? MontoTot { get; set; }

    public string? CodIntBcp { get; set; }

    public string? Casilla { get; set; }

    public string? Filler { get; set; }

    public decimal? MontoTotD { get; set; }

    public string? EstImpBanco { get; set; }

    public string? NombreArchivo { get; set; }

    public decimal? CantTotRegD { get; set; }

    public DateOnly? FecOperacion { get; set; }

    public decimal? MontoTotProcesado { get; set; }

    public int? CantTotRegProcesado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
