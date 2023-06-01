using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManegermentPond.Controller
{
    public class BillInforController
    {
        private readonly QuanLyAoNuoiContext _db;
        public BillInforController(QuanLyAoNuoiContext db)
        {
            _db = db;
        }

        public void AddBillInfor(int IdBill, int IdCate, int number)
        {
            var mode = _db.BillInfors.Where(i => i.IdBill == IdBill && i.IdCate == IdCate).FirstOrDefault();
            if(mode == null)
            {
                BillInfor billInfor = new BillInfor()
                {
                    IdBill = IdBill,
                    IdCate = IdCate,
                    Number = number
                };
                _db.BillInfors.Add(billInfor);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
            }
            else
            {
                mode.Number += number;
                _db.BillInfors.Update(mode);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
            }
        }
    }
}
