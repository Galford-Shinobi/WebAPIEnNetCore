using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Compra
{
    public int CompraId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ProveedorId { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Proveedor? Proveedor { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
