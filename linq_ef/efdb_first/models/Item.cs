using System;
using System.Collections.Generic;

namespace efdb_first.models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
