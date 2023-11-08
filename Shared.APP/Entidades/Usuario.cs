using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? Documento { get; set; }

    public string? NomkbreCompleto { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public int? RolId { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Rol? Rol { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
