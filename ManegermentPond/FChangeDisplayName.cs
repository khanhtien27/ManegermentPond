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
    public partial class FChangeDisplayName : Form
    {
        private Account _account;
        private QuanLyAoNuoiContext _db;
        public FChangeDisplayName(Account account, QuanLyAoNuoiContext db)
        {
            _account = account;
            _db = db;
            InitializeComponent();
            _load();
        }

        void _load()
        {
            tbDisplay.Text = _account.DisplayName;
        }
        void _changeDisplay()
        {
            if (tbnewdisplay.Text.IsNullOrEmpty())
            {
                MessageBox.Show("New display is empty !!", "Warning", MessageBoxButtons.OK);
            }
            if (tbpass.Text != tbreass.Text)
            {
                MessageBox.Show("Please retype password !!", "Warning", MessageBoxButtons.OK);
            }


            if (tbnewdisplay.Text != "" && tbpass.Text == tbreass.Text)
            {
                var model = _db.Accounts.Where(i => i.DisplayName == tbDisplay.Text && i.Password == tbpass.Text).FirstOrDefault();
                if (model == null)
                {
                    MessageBox.Show("Password is incorect !!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    model.DisplayName = tbnewdisplay.Text;
                    _db.Accounts.Update(model);
                    _db.SaveChanges();
                    _db.ChangeTracker.Clear();

                    MessageBox.Show("Update succesful !!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    updateAccount(this, new AccountEvent(model));
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure exit ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            _changeDisplay();
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

    }

    public class AccountEvent : EventArgs
    {
        public Account _account;
        public AccountEvent(Account account)
        {
            _account = account;
        }
    }
}
