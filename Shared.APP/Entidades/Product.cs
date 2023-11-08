﻿using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }
}
