using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdProd { get; set; }

    public double? Price { get; set; }

    public double? PriceSale { get; set; }

    public int? Protein { get; set; }

    public string? Decription { get; set; }

    public virtual ICollection<BillInfor> BillInfors { get; set; } = new List<BillInfor>();

    public virtual Product IdProdNavigation { get; set; } = null!;
}
