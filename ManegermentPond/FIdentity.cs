using ManegermentPond.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManegermentPond
{
    public partial class FIdentity : Form
    {
        private Account _account;
        private QuanLyAoNuoiContext _db;
        public FIdentity(Account account, QuanLyAoNuoiContext db)
        {
            _db = db;
            _account = account;
            InitializeComponent();
            _loadAccount();
        }

        void _loadAccount()
        {
            tbUsername.Text = _account.UserName.ToString();
            tbdisplayname.Text = _account.DisplayName.ToString();
            tbrole.Text = _account.Role.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FChangeDisplayName fc = new FChangeDisplayName(_account, _db);
            fc.UpdateAccount += Fc_UpdateAccount;// truyen tu form con qua form cha
            
            fc.ShowDialog();
            
        }

        private void Fc_UpdateAccount(object? sender, AccountEvent e)
        {
            tbdisplayname.Text = e._account.DisplayName.ToString();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FChangePassword fc = new FChangePassword(_account, _db);
            this.Hide();
            fc.ShowDialog();
            this.Show();
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
