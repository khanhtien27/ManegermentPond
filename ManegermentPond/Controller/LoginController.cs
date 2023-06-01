using ManegermentPond.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManegermentPond.Controller
{
    public class LoginController
    {
        private readonly QuanLyAoNuoiContext _db;
        public LoginController(QuanLyAoNuoiContext db)
        {
            _db = db;
        }

        public bool Login(string username, string password)
        {
            var model = _db.Accounts.Where(i => i.UserName.ToLower() == username.ToLower() && i.Password == password).FirstOrDefault();
            if(model == null)
            {
                return false;
            }
            else { return true; }
        }
    }
}
