using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal PrecioProducto { get; set; }

    public string? DescripcionProducto { get; set; }

    public int IdCategoria { get; set; }

    public int StockProducto { get; set; }

    public string AvatarProducto { get; set; } = null!;

    public string TipoProducto { get; set; } = null!;

    public int? CondicionProducto { get; set; }

    public int? StockPrevio { get; set; }

    public string? Alias { get; set; }
}
