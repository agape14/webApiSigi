using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TblValidaArchivoBanco
{
    public int Idtbl { get; set; }

    public int? NumContrato { get; set; }

    public int? Mes { get; set; }

    public int? Anio { get; set; }
}
