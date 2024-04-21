using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TDatosCobranzaTmp
{
    public int CodDatCobranza { get; set; }

    public string? TipoComprob { get; set; }

    public string? CodPersonaComprob { get; set; }

    public string? RucComprob { get; set; }

    public string? TipoDocPersComprob { get; set; }

    public string? NombreCompletoComprob { get; set; }

    public int? CodConcepto { get; set; }

    public string? Tipo { get; set; }

    public int? CodContrato { get; set; }

    public string? EstPago { get; set; }

    public string? EnviadoBanco { get; set; }

    public int? CodActo { get; set; }
}
