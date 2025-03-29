using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class Sale
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public int MedicineId { get; set; }

    public int UserId { get; set; }

    public virtual Product Medicine { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
