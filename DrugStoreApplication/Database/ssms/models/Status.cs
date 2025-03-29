﻿using System;
using System.Collections.Generic;

namespace DrugStoreApplication.Database.ssms.models;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
