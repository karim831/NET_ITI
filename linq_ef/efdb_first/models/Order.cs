using System;
using System.Collections.Generic;

namespace efdb_first.models;

public partial class Order
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
