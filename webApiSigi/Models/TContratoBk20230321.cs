using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TContratoBk20230321
{
    public int CodPcont { get; set; }

    public int? CodConcepto { get; set; }

    public int CodContrato { get; set; }

    public int? NumCuota { get; set; }

    public int? CodIngreso { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public decimal? Insoluto { get; set; }

    public decimal? InteresDiario { get; set; }

    public int? DiasAtrazados { get; set; }

    public decimal? InteresAcumulado { get; set; }

    public decimal? TotalDeuda { get; set; }

    public decimal? Pagado { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? EstPago { get; set; }

    public int? NumContrato { get; set; }

    public string? NomDepositante { get; set; }

    public string? Canal { get; set; }

    public int? CodComprob { get; set; }

    public int? Ticket { get; set; }

    public string? Tipo { get; set; }

    public DateOnly? FechaValidoCanal { get; set; }

    public string? DocumentoPago { get; set; }

    public string? DireccionInmueble { get; set; }

    public string? Ubigeo { get; set; }

    public string? TipoComprob { get; set; }

    public string? CodPersonaComprob { get; set; }

    public string? RucComprob { get; set; }

    public string? TipoDocPersComprob { get; set; }

    public string? NombreCompletoComprob { get; set; }

    public string? EnviadoBanco { get; set; }

    public string? AccionBanco { get; set; }

    public DateOnly? FecEnvioBanco { get; set; }

    public decimal? Anticipo { get; set; }

    public int? CodIngresoAnticipo { get; set; }

    public double? ImporteAdicional { get; set; }

    public string? MotImporteAdicional { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public int? TicketAutorizado { get; set; }

    public DateOnly? TicketVence { get; set; }

    public int? AutorizaAnulado { get; set; }

    public DateOnly? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateOnly? FechaAutoriza { get; set; }

    public string? UsuarioAutoriza { get; set; }

    public string? CancelaComprob { get; set; }
}
