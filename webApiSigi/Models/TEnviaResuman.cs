using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TEnviaResuman
{
    public int IId { get; set; }

    public int? CodComprob { get; set; }

    public string? Fecha { get; set; }

    public int? Estado { get; set; }
}
