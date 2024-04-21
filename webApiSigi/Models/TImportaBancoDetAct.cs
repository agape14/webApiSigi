using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TImportaBancoDetAct
{
    public int CodIbancoD { get; set; }

    public int? CodIbanco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? FecProceso { get; set; }

    public string? CodInternoCuenta { get; set; }

    public string? CodIdUsiario { get; set; }

    public string? FecVencimientoCupon { get; set; }

    public string? TipoRegActualizacion { get; set; }

    public string? EstAccion { get; set; }

    public string? Observaciones { get; set; }

    public string? Filler { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
