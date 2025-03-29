using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int Quantity { get; set; }

    public string? ImagePath { get; set; }

    public int SupplierId { get; set; }

    public int TypeId { get; set; }

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Type Type { get; set; } = null!;
}
