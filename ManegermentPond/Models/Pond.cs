using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class Pond
{
    public int Id { get; set; }

    public int? Status { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public int? Acreage { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
