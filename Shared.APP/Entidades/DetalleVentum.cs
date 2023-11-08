using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class DetalleVentum
{
    public int DetalleVentaId { get; set; }

    public int? VentaId { get; set; }

    public int? ProductoId { get; set; }

    public decimal? PrecioVenta { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual Ventum? Venta { get; set; }
}
