using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int Cost { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public int SupplierId { get; set; }

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();

    public virtual Status Status { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
