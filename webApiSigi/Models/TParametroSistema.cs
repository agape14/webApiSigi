using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TParametroSistema
{
    public int CodSis { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }

    public string? Codigo { get; set; }

    public string? Adm { get; set; }

    public string? TipoDato { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
