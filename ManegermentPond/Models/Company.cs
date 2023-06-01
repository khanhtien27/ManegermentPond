using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public int? Rate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
