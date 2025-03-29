using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class Type
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
