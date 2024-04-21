using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class Depositante
{
    public string? Fecha { get; set; }

    public string? Operacion { get; set; }

    public string? Importe { get; set; }

    public string? Persona { get; set; }

    public string? Cuenta { get; set; }
}
