using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TGuiaRemisionDet
{
    public int CodRemisionDet { get; set; }

    public int? CodRemision { get; set; }

    public string? MotivoTraslado { get; set; }

    public string? DescTraslado { get; set; }

    public int? IndicadorTransbordo { get; set; }

    public decimal? PesoTotal { get; set; }

    public string? UnidadMed { get; set; }

    public int? NroBultos { get; set; }

    public string? ModalidadTrasl { get; set; }

    public DateOnly? FechaIniTrasl { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public int? TipoDocTransp { get; set; }

    public string? NroDocTransp { get; set; }

    public string? NombreRazSocTransp { get; set; }

    public string? Vehiculo { get; set; }

    public int? TipoDocConducPriva { get; set; }

    public string? NroDocConducPriva { get; set; }

    public string? UbigeoLlegada { get; set; }

    public string? DireccionLlegada { get; set; }

    public string? UbigeoPartida { get; set; }

    public string? DireccionPartida { get; set; }

    public string? CodPuerto { get; set; }

    public string? NroContenedor { get; set; }

    public string? NroOrdenBien { get; set; }

    public int? CantidadBien { get; set; }

    public string? UnidMedBien { get; set; }

    public string? DescripcionBien { get; set; }

    public string? CodigoBien { get; set; }

    public string? CodigoSunat { get; set; }
}
