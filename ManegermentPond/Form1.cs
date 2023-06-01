using ManegermentPond.Controller;
using ManegermentPond.Models;
using System.Globalization;
using System.Security.AccessControl;

namespace ManegermentPond
{
    public partial class FMain : Form
    {
        private QuanLyAoNuoiContext _db;
        private Account _acccount;

        public FMain(QuanLyAoNuoiContext db, Account acccount)
        {
            _db = db;
            _acccount = acccount;
            InitializeComponent();
            IdentityToolStrip.Text += " (" + _acccount.DisplayName + ")";
            changeAdmin(_acccount);
            _LoadPond();
            _LoadCpn();
            _loadListPond();
        }


        void changeAdmin(Account acccount)
        {
            adminToolStripMenuItem.Enabled = acccount.Role == "admin";
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            listView.Items.Clear();

            int IdPond = ((sender as Button).Tag as Pond).Id;
            listView.Tag = (sender as Button).Tag;
            _ShowBill(IdPond);

        }

        void _ShowBill(int IdPond)
        {
            listView.Items.Clear();
            double? total = 0;
            var bill = new BillController(_db);
            var model = bill.GetBillByIdPond(IdPond);
            if (model != null)
            {
                var md = _showBillInfor(model.Id);
                if (md != null)
                {
                    foreach (var p in md)
                    {

                        var mod = _db.Categories.Where(i => i.Id == p.IdCate).Join(_db.Products,
                            c => c.IdProd,
                            p => p.Id,
                            (c, p) => new
                            {
                                Name = c.Name,
                                NameProduct = p.Name,
                                Decription = c.Decription,
                                Protein = c.Protein,
                                Rate = c.Price
                            }).FirstOrDefault();
                        if (mod != null)
                        {
                            ListViewItem lv = new ListViewItem(p.Number.ToString());
                            lv.SubItems.Add(mod.NameProduct.ToString());
                            lv.SubItems.Add(mod.Name.ToString());
                            lv.SubItems.Add(mod.Decription.ToString());
                            lv.SubItems.Add(mod.Protein.ToString());
                            lv.SubItems.Add(mod.Rate?.ToString());
                            total += mod.Rate * p.Number;
                            listView.Items.Add(lv);
                        }
                    }
                }
            }
            tbTotalPrice.Text = total?.ToString("c", new CultureInfo("vi-VN"));
        }
        List<BillInfor> _showBillInfor(int Id)
        {
            var model = _db.BillInfors.Where(i => i.IdBill == Id).ToList();
            if (model.Count > 0)
            {
                return model;
            }
            return null;
        }
        void _LoadPond()
        {
            flpPond.Controls.Clear();
            var listPond = new PondController(_db);
            List<Pond> list = listPond.LoadPondList();
            foreach (Pond p in list)
            {
                Button btn = new Button() { Width = Convert.ToInt32(Math.Sqrt(p.Acreage.Value)) + 50, Height = Convert.ToInt32(Math.Sqrt(p.Acreage.Value)) + 50, Text = p.Name };
                btn.Tag = p;
                if (p.Status == 0)
                {
                    btn.Text += Environment.NewLine + "Emty Pond";
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.Text += Environment.NewLine + "Rasing";
                    btn.BackColor = Color.Aqua;
                }
                btn.Click += Btn_Click;
                flpPond.Controls.Add(btn);
            }
        }

        void _LoadCpn()
        {
            var model = _db.Companies.ToList();
            cbbCty.DataSource = model;
            cbbCty.DisplayMember = "Name";
        }
        void _LoadProd(int Id)
        {
            var model = _db.Products.Where(p => p.IdCpn == Id).ToList();
            cbbProd.DataSource = model;
            cbbProd.DisplayMember = "Name";
        }
        void _LoadCate(int Id)
        {
            var model = _db.Categories.Where(p => p.IdProd == Id).ToList();
            cbbCate.DataSource = model;
            cbbCate.DisplayMember = "Name";
        }
        void _loadListPond()
        {
            var model = _db.Ponds.ToList();
            cbbChangePond.DataSource = model;
            cbbChangePond.DisplayMember = "Name";
        }

        private void cbbCty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb == null) return;
            var select = cb.SelectedItem as Company;
            id = select.Id;
            _LoadProd(id);
        }

        private void cbbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb == null) return;
            var select = cb.SelectedItem as Product;
            id = select.Id;
            _LoadCate(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idcate = (cbbCate.SelectedItem as Category).Id;
            int number = Convert.ToInt32(Number.Value);
            var pond = listView.Tag as Pond;
            BillController bill = new BillController(_db);
            BillInforController billinfor = new BillInforController(_db);
            var getbill = bill.GetBillByIdPond(pond.Id);
            if (getbill == null)
            {
                bill.AddBill(pond.Id);
                var getbill2 = bill.GetBillByIdPond(pond.Id);
                billinfor.AddBillInfor(getbill2.Id, idcate, number);
            }
            else
            {
                billinfor.AddBillInfor(getbill.Id, idcate, number);
            }

            _ShowBill(pond.Id);
            _LoadPond();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure Total this Pond ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                var Pond = listView.Tag as Pond;
                var bill = new BillController(_db);
                bill.checkOutBill(Pond.Id);
                _ShowBill(Pond.Id);
                _LoadPond();
            }
        }

        private void bntchangePond_Click(object sender, EventArgs e)
        {
            Pond pond = listView.Tag as Pond;
            Pond pondChange = cbbChangePond.SelectedItem as Pond;
            BillController bill = new BillController(_db);

            var billPondChange = bill.GetBillByIdPond(pondChange.Id);
            var billPond = bill.GetBillByIdPond(pond.Id);

            if (pond.Id == pondChange.Id)
            {
                _LoadPond();
            }
            if (pond.Id != pondChange.Id && billPondChange == null && billPond != null)
            {
                billPond.IdPond = pondChange.Id;
                _db.Bills.Update(billPond);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();

                pond.Status = 0;
                _db.Ponds.Update(pond);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();

                pondChange.Status = 1;
                _db.Ponds.Update(pondChange);
                _db.SaveChanges();

                _db.ChangeTracker.Clear();
            }
            if (pond.Id != pondChange.Id && billPondChange != null && billPond != null)
            {
                var listbillInfor = _showBillInfor(billPond.Id);

                foreach (BillInfor item in listbillInfor)
                {
                    BillInforController billInfor = new BillInforController(_db);
                    billInfor.AddBillInfor(billPondChange.Id, (int)item.IdCate, (int)item.Number);
                    _db.BillInfors.Remove(item);
                    _db.SaveChanges();
                    _db.ChangeTracker.Clear();
                }

                _db.Bills.Remove(billPond);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();

                pond.Status = 0;
                _db.Ponds.Update(pond);
                _db.SaveChanges();
                _db.ChangeTracker.Clear();
            }

            _LoadPond();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin fAdmin = new FAdmin(_db);
            fAdmin.ShowDialog();
        }

        private void IdentityToolStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            FIdentity fi = new FIdentity(_acccount, _db);
            fi.ShowDialog();
            this.Show();
        }
    }
}