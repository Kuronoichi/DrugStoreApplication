﻿using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class ProductsOrder
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
