﻿using System;
using System.Collections.Generic;

namespace Shared.APP.Entidades;

public partial class Order
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public int ClientId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? Total { get; set; }

    public virtual Client Client { get; set; } = null!;
}
