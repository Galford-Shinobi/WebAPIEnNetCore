using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Permiso
{
    public int PermisoId { get; set; }

    public int? RolId { get; set; }

    public string? NombreMenu { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Rol? Rol { get; set; }
}
