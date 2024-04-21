using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class PersonasItl
{
    public int IIdtabla { get; set; }

    public string? Dni { get; set; }

    public string? Nombres { get; set; }

    public string? Telefono { get; set; }

    public int? Migrado { get; set; }
}
