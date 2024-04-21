using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TParticipanteSubastum
{
    public int CodPartSub { get; set; }

    public int CodSubasta { get; set; }

    public int CodPostor { get; set; }

    public string CodPersona { get; set; } = null!;

    public string? NombreCompleto { get; set; }

    public string? TipoDoc { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
