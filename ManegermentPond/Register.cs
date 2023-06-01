using ManegermentPond.Controller;
using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManegermentPond
{
    public partial class Register : Form
    {
        private QuanLyAoNuoiContext _db;
        public Register(QuanLyAoNuoiContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void BTNReg_Click(object sender, EventArgs e)
        {
            string user = TBUserReg.Text;
            string pass = TBPassReg.Text;
            string display = TBDisplayReg.Text;
            
            if (_Regis(user, pass, display))
            {
                MessageBox.Show("Regis is Successful");
                Login login = new Login(_db);
                this.Hide();
                login.Show();
                
            }
            else
            {
                MessageBox.Show("Have Problem ocur");
            }
        }

        bool _Regis(string username, string password, string displayname)
        {
            var regis = new RegisterController(_db);
            return regis.Register(username, password, displayname);
        }
    }
}
