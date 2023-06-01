using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class BillInfor
{
    public int Id { get; set; }

    public int IdBill { get; set; }

    public int? IdCate { get; set; }

    public int? Number { get; set; }

    public virtual Bill IdBillNavigation { get; set; } = null!;

    public virtual Category? IdCateNavigation { get; set; }
}
