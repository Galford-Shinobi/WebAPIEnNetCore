using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Ventum
{
    public int VentaId { get; set; }

    public int? UsuarioId { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? DocumentoCliente { get; set; }

    public string? NombreCliente { get; set; }

    public decimal? MontoPago { get; set; }

    public decimal? MontoCambio { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? TipoDocumento { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Usuario? Usuario { get; set; }
}
