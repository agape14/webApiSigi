using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TGuiaRemisionCab
{
    public int CodRemision { get; set; }

    public string? SerieRem { get; set; }

    public int? CorrelativoRem { get; set; }

    public DateOnly? FechaRem { get; set; }

    public string? Hora { get; set; }

    public string? TipoDocRem { get; set; }

    public string? ObservacionRem { get; set; }

    public string? TipoDocDestinatario { get; set; }

    public string? NroDocDestinatario { get; set; }

    public string? NombreRazSocDest { get; set; }

    public string? DireccionRazSocDest { get; set; }

    public string? CorreoRazSocDest { get; set; }
}
