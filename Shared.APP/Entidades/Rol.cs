using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Rol
{
    public int RolId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
