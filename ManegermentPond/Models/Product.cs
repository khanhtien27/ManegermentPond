using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Cate { get; set; }

    public string? Name { get; set; }

    public int? IdCpn { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual Company? IdCpnNavigation { get; set; }
}
