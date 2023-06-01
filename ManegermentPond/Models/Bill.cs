using System;
using System.Collections.Generic;

namespace ManegermentPond.Models;

public partial class Bill
{
    public int Id { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int Status { get; set; }

    public int IdPond { get; set; }

    public virtual ICollection<BillInfor> BillInfors { get; set; } = new List<BillInfor>();

    public virtual Pond IdPondNavigation { get; set; } = null!;
}
