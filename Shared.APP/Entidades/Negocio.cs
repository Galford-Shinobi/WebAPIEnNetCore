using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Negocio
{
    public int NegocioId { get; set; }

    public string? Nombre { get; set; }

    public string? Rfc { get; set; }

    public string? Direccion { get; set; }

    public byte[]? Logo { get; set; }
}
