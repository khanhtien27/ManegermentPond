using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManegermentPond.Controller
{
    public class RegisterController
    {
        private readonly QuanLyAoNuoiContext _db;
        public RegisterController(QuanLyAoNuoiContext db)
        {
            _db = db;
        }

        public bool  Register(string username, string password, string displayname)
        {
            var mode = new Account() { UserName = username, Password =password, DisplayName = displayname};
            var result = _db.Accounts.Add(mode);
            _db.SaveChanges();

            var model = _db.Accounts.Where(i => i.UserName.ToLower() == username.ToLower() && i.Password == password).FirstOrDefault();
            if (model == null)
            {
                return false;
            }
            else { return true; }
        }
    }
}
