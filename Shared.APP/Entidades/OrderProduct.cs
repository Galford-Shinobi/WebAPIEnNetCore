﻿using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class OrderProduct
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }
}
