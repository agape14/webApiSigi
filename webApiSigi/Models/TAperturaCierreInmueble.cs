using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TAperturaCierreInmueble
{
    public int CodAperturaCierreInmueble { get; set; }

    public string? Anio { get; set; }

    public DateOnly? FecApertura { get; set; }

    public DateOnly? FecCierre { get; set; }

    public int? CodMargesiReporte { get; set; }

    public string? EstMargesiReporte { get; set; }
}
