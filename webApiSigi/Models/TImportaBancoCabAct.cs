using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TImportaBancoCabAct
{
    public int CodIbanco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? Filler1 { get; set; }

    public string? CantTotReg { get; set; }

    public string? Filler2 { get; set; }

    public string? FecProceso { get; set; }

    public string? Filler3 { get; set; }

    public string? EstImpBanco { get; set; }

    public string? NombreArchivo { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
