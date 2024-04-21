using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TExportaBancoDet
{
    public int CodEbancoD { get; set; }

    public int? CodEbanco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? CodIdUsiario { get; set; }

    public string? NomUsuario { get; set; }

    public string? InfoRetorno { get; set; }

    public string? FecEmisionCupo { get; set; }

    public string? FecVencimientoCupo { get; set; }

    public string? MontoCupo { get; set; }

    public string? MontoMora { get; set; }

    public string? MontoMinimo { get; set; }

    public string? TipoAccionRegistro { get; set; }

    public string? Filler { get; set; }

    public string? Ubigeo { get; set; }

    public DateOnly? EmisionD { get; set; }

    public DateOnly? VenceD { get; set; }

    public decimal? MontoD { get; set; }

    public string? Incluir { get; set; }

    public string? DireccionInmueble { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
