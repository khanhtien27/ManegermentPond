using ManegermentPond.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManegermentPond
{
    public partial class FAdmin : Form
    {
        private QuanLyAoNuoiContext _db;
        public FAdmin(QuanLyAoNuoiContext db)
        {
            _db = db;
            InitializeComponent();
            _loadListPond();
            _loadDatatimePicker();
            _loadData();
            _load();
        }

        void _loadListPond()
        {
            var model = _db.Ponds.ToList();
            cbbPond.DataSource = model;
            cbbPond.DisplayMember = "Name";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _loadData();
        }

        void _loadData()
        {
            Pond pond = cbbPond.SelectedItem as Pond;
            var date1 = datetimeFrom.Value.Date;
            var date2 = datetimeTo.Value.Date;
            var model = _db.Bills.Where(i => i.DateStart >= date1 && i.DateEnd <= date2 && i.IdPond == pond.Id && i.Status == 0).Join(_db.BillInfors,
                b => b.Id,
                bi => bi.IdBill,
                (b, bi) => new { b, bi }).Join(_db.Categories,
                j1 => j1.bi.IdCate,
                c => c.Id,
                (j1, c) => new { j1, c }).Join(_db.Products,
                j2 => j2.c.IdProd,
                p => p.Id,
                (j3, p) => new
                {
                    NameCategory = j3.c.Name,
                    NameProduct = p.Name,
                    Protein = j3.c.Protein,
                    Number = j3.j1.bi.Number,
                    PriceForKg = j3.c.Price,
                    Total = j3.j1.bi.Number * j3.c.Price,
                    Decription = j3.c.Decription,
                });
            dataGridView1.DataSource = model.ToList();
        }
        void _loadDatatimePicker()
        {
            DateTime today = DateTime.Today;
            datetimeFrom.Value = new DateTime(today.Year, today.Month, 1);
            datetimeTo.Value = datetimeFrom.Value.AddMonths(1).AddDays(-1);
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            FAddCompany fAddCompany = new FAddCompany(_db);
            fAddCompany.ShowDialog();
        }

        void _load()
        {
            var cpn = _db.Companies.ToList();
            var pro = _db.Products.ToList();
            var cate = _db.Categories.ToList();

            dgvCpn.DataSource = cpn;
            drgProd.DataSource = pro;
            drgCate.DataSource = cate;
            _bindingCompany();
            _bindingProduct();
            _bindingCate();
        }

        void _bindingCompany()
        {
            tbNameCpn.DataBindings.Add(new Binding("Text", dgvCpn.DataSource, "Name"));
            tbAddressCpn.DataBindings.Add(new Binding("Text", dgvCpn.DataSource, "Address"));
            tbRateCompany.DataBindings.Add(new Binding("Text", dgvCpn.DataSource, "Rate"));
        }

        void _bindingProduct()
        {
            tbNameProd.DataBindings.Add(new Binding("Text", drgProd.DataSource, "Name"));
            tbCateProd.DataBindings.Add(new Binding("Text", drgProd.DataSource, "Cate"));
            tbCpnProd.DataBindings.Add(new Binding("Text", drgProd.DataSource, "IdCPN"));

            //var id = Convert.ToInt32(tbCpnProd.Text.ToString());
            //var model = _db.Companies.Where(i => i.Id == id).Select(i => i.Name).FirstOrDefault();
            //tbShowCPN.Text = model;
        }

        void _bindingCate()
        {
            tbNameCate.DataBindings.Add(new Binding("Text", drgCate.DataSource, "Name"));
            tbProdCate.DataBindings.Add(new Binding("Text", drgCate.DataSource, "IdProd"));
            tbPriceCate.DataBindings.Add(new Binding("Text", drgCate.DataSource, "Price"));
            tbPridceSale.DataBindings.Add(new Binding("Text", drgCate.DataSource, "PriceSale"));
            tbProteinCate.DataBindings.Add(new Binding("Text", drgCate.DataSource, "Protein"));
            tbDecripCate.DataBindings.Add(new Binding("Text", drgCate.DataSource, "Decription"));
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void tbCpnProd_TextChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(tbCpnProd.Text.ToString());
            var model = _db.Companies.Where(i => i.Id == id).Select(i => i.Name).FirstOrDefault();
            tbShowCPN.Text = model;
        }

        private void tbProdCate_TextChanged(object sender, EventArgs e)
        {
            if (tbProdCate.Text != "")
            {
                var id = Convert.ToInt32(tbProdCate.Text.ToString());
                var model = _db.Products.Where(i => i.Id == id).Select(i => i.Name).FirstOrDefault();
                tbShowProd.Text = model;
            }
        }

        private void btnUpdateCpn_Click(object sender, EventArgs e)
        {
            try
            {
                var model = dgvCpn.SelectedRows[0].DataBoundItem as Company;
                model.Name = tbNameCpn.Text;
                model.Address = tbAddressCpn.Text;
                model.Rate = Convert.ToInt32(tbRateCompany.Text);

                _db.Companies.Update(model);
                _db.SaveChanges();

                MessageBox.Show("     Update successfull     ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("       Have some errors       ", "Wanring", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var model = dgvCpn.SelectedRows[0].DataBoundItem as Company;
                _db.Companies.Remove(model);
                _db.SaveChanges();
                MessageBox.Show("     Delete successfull     ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _load();
            }
            catch
            {
                MessageBox.Show("       Have some errors       ", "Wanring", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
