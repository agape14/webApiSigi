using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TImagenReporte
{
    public int? IdImagen { get; set; }

    public int? IdReporte { get; set; }

    public string? RutaImagen { get; set; }

    public int? NroPag { get; set; }
}
