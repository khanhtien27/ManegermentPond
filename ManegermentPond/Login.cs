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
    public partial class Login : Form
    {
        private QuanLyAoNuoiContext _db;
        public Login(QuanLyAoNuoiContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            string usename = TBUser.Text;
            string pass = TBPassword.Text;
            if (_Login(usename, pass))
            {
                var acc = _db.Accounts.Where(i => i.UserName == usename).FirstOrDefault();
                FMain fMain = new FMain(_db, acc);
                this.Hide();
                fMain.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("User Name or password is incorrect");
            }
        }


        private void Regis_Click(object sender, EventArgs e)
        {
            Register fMain = new Register(_db);
            this.Hide();
            fMain.ShowDialog();
            this.Show();
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            Application.Exit();
        }



        #region
        bool _Login(string username, string password)
        {
            var login = new LoginController(_db);
            return login.Login(username, password);
        }


        #endregion
    }
}
