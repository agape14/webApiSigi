using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TImportaBancoDet
{
    public int CodIbancoD { get; set; }

    public int? CodIbanco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? TipoRegistro { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodMoneda { get; set; }

    public string? NumCuentaEmpresa { get; set; }

    public string? CodIdUsiario { get; set; }

    public string? InfoRetorno { get; set; }

    public string? FecPago { get; set; }

    public string? FecVencimiento { get; set; }

    public string? MontoPagado { get; set; }

    public string? MontoMoraPagado { get; set; }

    public string? MontoTotalPagado { get; set; }

    public string? CodigoOficina { get; set; }

    public string? NumOperacion { get; set; }

    public string? Referencia { get; set; }

    public string? IdTerminal { get; set; }

    public string? MedioAtencion { get; set; }

    public string? HoraAtencion { get; set; }

    public string? NumCheque { get; set; }

    public string? CodBanco { get; set; }

    public string? CargoFijoPagado { get; set; }

    public string? Filler { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? InteresDiario { get; set; }

    public int? DiasAtrazados { get; set; }

    public decimal? InteresAcumulado { get; set; }

    public decimal? TotalDeuda { get; set; }

    public DateOnly? FecPagoD { get; set; }

    public decimal? MontoPagadoD { get; set; }

    public decimal? MontoMoraPagadoD { get; set; }

    public decimal? MontoTotalPagadoD { get; set; }

    public string? Validado { get; set; }

    public string? NombreUsuario { get; set; }

    public decimal? Diferencia { get; set; }

    public string? CuotaDestino { get; set; }

    public string? Procesado { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public string? MesPago { get; set; }

    public string? AnioPago { get; set; }

    public int? CodComprob { get; set; }

    public int? CodPcont { get; set; }

    public string? ComprobDesc { get; set; }
}
