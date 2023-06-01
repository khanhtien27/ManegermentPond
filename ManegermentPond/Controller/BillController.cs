using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManegermentPond.Controller
{
    public class BillController
    {
        private readonly QuanLyAoNuoiContext _db;
        public BillController(QuanLyAoNuoiContext db)
        {
            _db = db;
        }
        public Bill GetBillByIdPond(int idpond)
        {
            var model = _db.Bills.Where(i => i.IdPond == idpond && i.Status == 1).FirstOrDefault();
            if (model != null) return model;
            return null;
        }

        public void AddBill (int IdPond)
        {
            Bill bill = new Bill();
            var pond = _db.Ponds.Where(i => i.Id ==  IdPond).FirstOrDefault();
            pond.Status = 1;
            _db.Ponds.Update(pond);
            _db.SaveChanges();

            bill.IdPond = IdPond;
            bill.Status = 1;
            _db.Bills.Add(bill);
            _db.SaveChanges();
            _db.ChangeTracker.Clear();
        }
        
        public void checkOutBill (int idpond)
        {
            var model = _db.Bills.Where(i => i.IdPond == idpond && i.Status == 1).FirstOrDefault();
            if(model != null)
            {
                model.Status = 0;
                model.DateEnd = DateTime.Now;
                _db.Bills.Update(model);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
                
                var pond = _db.Ponds.Where(i => i.Id == idpond).FirstOrDefault();
                pond.Status = 0;
                _db.Ponds.Update(pond);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
            }
        }
    }
}
