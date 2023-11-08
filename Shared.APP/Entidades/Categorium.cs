using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Categorium
{
    public int CategoriaId { get; set; }

    public string? Descripcion { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
