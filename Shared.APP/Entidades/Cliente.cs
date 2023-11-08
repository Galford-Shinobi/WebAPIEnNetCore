using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Documento { get; set; }

    public string? NomkbreCompleto { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
