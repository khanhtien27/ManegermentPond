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
    public partial class FAddCompany : Form
    {
        private QuanLyAoNuoiContext _db;
        public FAddCompany(QuanLyAoNuoiContext db)
        {
            _db = db;
            InitializeComponent();
        }

            private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (tbNameAddCpn.Text != "" && tbAddRess.Text != "" && cbRateCPN.Text != "")
            {
                string name = tbNameAddCpn.Text;
                string address = tbAddRess.Text;
                int rate= Convert.ToInt32(cbRateCPN.Text);
                var model = _db.Companies.Where(i => i.Name == name).FirstOrDefault();
                if (model != null)
                {
                    MessageBox.Show("Name is already exits");
                }
                else
                {
                    Company cp = new Company();
                    cp.Name = name;
                    cp.Address = address;
                    cp.Rate = rate;
                    _db.Companies.Add(cp);
                    _db.SaveChanges();
                    _db.ChangeTracker.Clear();
                    MessageBox.Show("Create company was successful");
                }
            }
            else
            {
                MessageBox.Show("Check again value!");
            }
        }
    }
}
