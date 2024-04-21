using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class ReporteMargesi
{
    public int Id { get; set; }

    public int? CodProv { get; set; }

    public int? Anio { get; set; }
}
