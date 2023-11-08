using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class DetalleCompra
{
    public int DetalleCompraId { get; set; }

    public int? CompraId { get; set; }

    public int? ProductoId { get; set; }

    public decimal? PrecioCompra { get; set; }

    public decimal? PrecioVenta { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Compra? Compra { get; set; }

    public virtual Producto? Producto { get; set; }
}
