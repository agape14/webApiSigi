using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TblComprobantesSi
{
    public int IIdTbl { get; set; }

    public string? Comprobante { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public string? Glosa { get; set; }
}
