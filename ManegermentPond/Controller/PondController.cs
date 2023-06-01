using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManegermentPond.Controller
{
    public class PondController
    {
        private QuanLyAoNuoiContext _db;
        public PondController(QuanLyAoNuoiContext db)
        {
            _db = db;
        }
        public List<Pond> LoadPondList()
        {
            List<Pond> list = new List<Pond>();
            list = _db.Ponds.ToList();
            return list;
        }


    }
}
