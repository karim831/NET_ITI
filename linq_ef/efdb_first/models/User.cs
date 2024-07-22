using System;
using System.Collections.Generic;

namespace efdb_first.models;

public partial class User
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
