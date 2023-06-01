using ManegermentPond.Models;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FChangePassword : Form
    {
        private Account _account;
        private QuanLyAoNuoiContext _db;
        public FChangePassword(Account account, QuanLyAoNuoiContext db)
        {
            _account = account;
            _db = db;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter a password you want to change!!", "Warning", MessageBoxButtons.OK);
            }
            var model = _db.Accounts.Where(i => i.Password == tbPassword.Text).FirstOrDefault();

            if (model == null)
            {
                MessageBox.Show("Password is incorect !!", "Warning", MessageBoxButtons.OK);
            }
            if (model != null && tbPassword.Text != tbNewpass.Text && tbNewpass.Text == tbReNewPass.Text)
            {
                model.Password = tbNewpass.Text;
                _db.Accounts.Update(model);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
                MessageBox.Show("Password is change successful !!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure exit ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
