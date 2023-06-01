namespace ManegermentPond
{
    partial class FAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Check = new TabControl();
            tpCheck = new TabPage();
            cbbPond = new ComboBox();
            btnSubmit = new Button();
            datetimeTo = new DateTimePicker();
            datetimeFrom = new DateTimePicker();
            dataGridView1 = new DataGridView();
            tpFeed = new TabPage();
            tpAccount = new TabPage();
            Product = new TabControl();
            tabPage1 = new TabPage();
            tbRateCompany = new TextBox();
            tbAddressCpn = new TextBox();
            tbNameCpn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btndelete = new Button();
            btnUpdateCpn = new Button();
            btnAddCompany = new Button();
            dgvCpn = new DataGridView();
            tabPage4 = new TabPage();
            tbShowCPN = new TextBox();
            tbCpnProd = new TextBox();
            tbCateProd = new TextBox();
            tbNameProd = new TextBox();
            Company = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDeleteProd = new Button();
            btnUpdateProd = new Button();
            btnAddProd = new Button();
            drgProd = new DataGridView();
            tabPage5 = new TabPage();
            tbShowProd = new TextBox();
            tbDecripCate = new TextBox();
            tbProteinCate = new TextBox();
            tbPridceSale = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbPriceCate = new TextBox();
            tbProdCate = new TextBox();
            tbNameCate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnDeleCate = new Button();
            btnUpdateCate = new Button();
            btnAddCate = new Button();
            drgCate = new DataGridView();
            tpPond = new TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            Check.SuspendLayout();
            tpCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpAccount.SuspendLayout();
            Product.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCpn).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgProd).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgCate).BeginInit();
            SuspendLayout();
            // 
            // Check
            // 
            Check.Controls.Add(tpCheck);
            Check.Controls.Add(tpFeed);
            Check.Controls.Add(tpAccount);
            Check.Controls.Add(tpPond);
            Check.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Check.Location = new Point(-1, 8);
            Check.Name = "Check";
            Check.SelectedIndex = 0;
            Check.Size = new Size(882, 473);
            Check.TabIndex = 0;
            // 
            // tpCheck
            // 
            tpCheck.Controls.Add(cbbPond);
            tpCheck.Controls.Add(btnSubmit);
            tpCheck.Controls.Add(datetimeTo);
            tpCheck.Controls.Add(datetimeFrom);
            tpCheck.Controls.Add(dataGridView1);
            tpCheck.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tpCheck.Location = new Point(4, 28);
            tpCheck.Name = "tpCheck";
            tpCheck.Padding = new Padding(3);
            tpCheck.Size = new Size(874, 441);
            tpCheck.TabIndex = 0;
            tpCheck.Text = "Check";
            tpCheck.UseVisualStyleBackColor = true;
            // 
            // cbbPond
            // 
            cbbPond.FormattingEnabled = true;
            cbbPond.Location = new Point(720, 14);
            cbbPond.Name = "cbbPond";
            cbbPond.Size = new Size(120, 25);
            cbbPond.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(333, 13);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(76, 24);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // datetimeTo
            // 
            datetimeTo.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datetimeTo.Location = new Point(477, 14);
            datetimeTo.Name = "datetimeTo";
            datetimeTo.Size = new Size(213, 25);
            datetimeTo.TabIndex = 2;
            datetimeTo.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // datetimeFrom
            // 
            datetimeFrom.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datetimeFrom.Location = new Point(52, 14);
            datetimeFrom.Name = "datetimeFrom";
            datetimeFrom.Size = new Size(224, 25);
            datetimeFrom.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(868, 392);
            dataGridView1.TabIndex = 0;
            // 
            // tpFeed
            // 
            tpFeed.Location = new Point(4, 28);
            tpFeed.Name = "tpFeed";
            tpFeed.Padding = new Padding(3);
            tpFeed.Size = new Size(874, 441);
            tpFeed.TabIndex = 1;
            tpFeed.Text = "Account";
            tpFeed.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(Product);
            tpAccount.Location = new Point(4, 28);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(874, 441);
            tpAccount.TabIndex = 2;
            tpAccount.Text = "Feed";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            Product.Controls.Add(tabPage1);
            Product.Controls.Add(tabPage4);
            Product.Controls.Add(tabPage5);
            Product.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Product.Location = new Point(6, 5);
            Product.Margin = new Padding(2);
            Product.Name = "Product";
            Product.SelectedIndex = 0;
            Product.Size = new Size(865, 434);
            Product.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbRateCompany);
            tabPage1.Controls.Add(tbAddressCpn);
            tabPage1.Controls.Add(tbNameCpn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btndelete);
            tabPage1.Controls.Add(btnUpdateCpn);
            tabPage1.Controls.Add(btnAddCompany);
            tabPage1.Controls.Add(dgvCpn);
            tabPage1.ForeColor = SystemColors.Highlight;
            tabPage1.Location = new Point(4, 26);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(857, 404);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Company";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbRateCompany
            // 
            tbRateCompany.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbRateCompany.Location = new Point(620, 211);
            tbRateCompany.Name = "tbRateCompany";
            tbRateCompany.Size = new Size(220, 26);
            tbRateCompany.TabIndex = 9;
            // 
            // tbAddressCpn
            // 
            tbAddressCpn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbAddressCpn.Location = new Point(620, 161);
            tbAddressCpn.Name = "tbAddressCpn";
            tbAddressCpn.Size = new Size(220, 26);
            tbAddressCpn.TabIndex = 8;
            // 
            // tbNameCpn
            // 
            tbNameCpn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNameCpn.Location = new Point(620, 114);
            tbNameCpn.Name = "tbNameCpn";
            tbNameCpn.Size = new Size(220, 26);
            tbNameCpn.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(531, 218);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 6;
            label3.Text = "Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(531, 168);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 5;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(531, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // btndelete
            // 
            btndelete.ForeColor = Color.Crimson;
            btndelete.Location = new Point(702, 352);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(148, 46);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnUpdateCpn
            // 
            btnUpdateCpn.Location = new Point(531, 352);
            btnUpdateCpn.Name = "btnUpdateCpn";
            btnUpdateCpn.Size = new Size(148, 47);
            btnUpdateCpn.TabIndex = 2;
            btnUpdateCpn.Text = "Update";
            btnUpdateCpn.UseVisualStyleBackColor = true;
            btnUpdateCpn.Click += btnUpdateCpn_Click;
            // 
            // btnAddCompany
            // 
            btnAddCompany.ForeColor = Color.Chartreuse;
            btnAddCompany.Location = new Point(620, 5);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(148, 45);
            btnAddCompany.TabIndex = 1;
            btnAddCompany.Text = "Add Company";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // dgvCpn
            // 
            dgvCpn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCpn.Location = new Point(5, 5);
            dgvCpn.Name = "dgvCpn";
            dgvCpn.RowTemplate.Height = 25;
            dgvCpn.Size = new Size(520, 394);
            dgvCpn.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tbShowCPN);
            tabPage4.Controls.Add(tbCpnProd);
            tabPage4.Controls.Add(tbCateProd);
            tabPage4.Controls.Add(tbNameProd);
            tabPage4.Controls.Add(Company);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(btnDeleteProd);
            tabPage4.Controls.Add(btnUpdateProd);
            tabPage4.Controls.Add(btnAddProd);
            tabPage4.Controls.Add(drgProd);
            tabPage4.ForeColor = SystemColors.Highlight;
            tabPage4.Location = new Point(4, 26);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(857, 404);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Product";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbShowCPN
            // 
            tbShowCPN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbShowCPN.Location = new Point(620, 220);
            tbShowCPN.Name = "tbShowCPN";
            tbShowCPN.Size = new Size(184, 26);
            tbShowCPN.TabIndex = 10;
            // 
            // tbCpnProd
            // 
            tbCpnProd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbCpnProd.Location = new Point(810, 220);
            tbCpnProd.Name = "tbCpnProd";
            tbCpnProd.Size = new Size(30, 26);
            tbCpnProd.TabIndex = 9;
            tbCpnProd.TextChanged += tbCpnProd_TextChanged;
            // 
            // tbCateProd
            // 
            tbCateProd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbCateProd.Location = new Point(620, 161);
            tbCateProd.Name = "tbCateProd";
            tbCateProd.Size = new Size(220, 26);
            tbCateProd.TabIndex = 8;
            // 
            // tbNameProd
            // 
            tbNameProd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNameProd.Location = new Point(620, 114);
            tbNameProd.Name = "tbNameProd";
            tbNameProd.Size = new Size(220, 26);
            tbNameProd.TabIndex = 7;
            // 
            // Company
            // 
            Company.AutoSize = true;
            Company.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Company.Location = new Point(533, 220);
            Company.Name = "Company";
            Company.Size = new Size(72, 19);
            Company.TabIndex = 6;
            Company.Text = "Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(533, 170);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(533, 119);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 4;
            label6.Text = "Name";
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.ForeColor = Color.Crimson;
            btnDeleteProd.Location = new Point(702, 352);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(148, 46);
            btnDeleteProd.TabIndex = 3;
            btnDeleteProd.Text = "Delete";
            btnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProd
            // 
            btnUpdateProd.Location = new Point(531, 352);
            btnUpdateProd.Name = "btnUpdateProd";
            btnUpdateProd.Size = new Size(148, 47);
            btnUpdateProd.TabIndex = 2;
            btnUpdateProd.Text = "Update";
            btnUpdateProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            btnAddProd.ForeColor = Color.Chartreuse;
            btnAddProd.Location = new Point(620, 5);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(148, 45);
            btnAddProd.TabIndex = 1;
            btnAddProd.Text = "Add Product";
            btnAddProd.UseVisualStyleBackColor = true;
            // 
            // drgProd
            // 
            drgProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgProd.Location = new Point(5, 5);
            drgProd.Name = "drgProd";
            drgProd.RowTemplate.Height = 25;
            drgProd.Size = new Size(520, 394);
            drgProd.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tbShowProd);
            tabPage5.Controls.Add(tbDecripCate);
            tabPage5.Controls.Add(tbProteinCate);
            tabPage5.Controls.Add(tbPridceSale);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(tbPriceCate);
            tabPage5.Controls.Add(tbProdCate);
            tabPage5.Controls.Add(tbNameCate);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(btnDeleCate);
            tabPage5.Controls.Add(btnUpdateCate);
            tabPage5.Controls.Add(btnAddCate);
            tabPage5.Controls.Add(drgCate);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(857, 404);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Category";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbShowProd
            // 
            tbShowProd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbShowProd.Location = new Point(621, 103);
            tbShowProd.Name = "tbShowProd";
            tbShowProd.Size = new Size(187, 26);
            tbShowProd.TabIndex = 26;
            // 
            // tbDecripCate
            // 
            tbDecripCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbDecripCate.Location = new Point(621, 254);
            tbDecripCate.Name = "tbDecripCate";
            tbDecripCate.Size = new Size(220, 26);
            tbDecripCate.TabIndex = 25;
            // 
            // tbProteinCate
            // 
            tbProteinCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbProteinCate.Location = new Point(621, 213);
            tbProteinCate.Name = "tbProteinCate";
            tbProteinCate.Size = new Size(220, 26);
            tbProteinCate.TabIndex = 24;
            tbProteinCate.TextChanged += textBox9_TextChanged;
            // 
            // tbPridceSale
            // 
            tbPridceSale.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbPridceSale.Location = new Point(621, 178);
            tbPridceSale.Name = "tbPridceSale";
            tbPridceSale.Size = new Size(220, 26);
            tbPridceSale.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DodgerBlue;
            label10.Location = new Point(532, 261);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 22;
            label10.Text = "Decription";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(534, 222);
            label11.Name = "label11";
            label11.Size = new Size(57, 19);
            label11.TabIndex = 21;
            label11.Text = "Protein";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(534, 183);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 20;
            label12.Text = "PriceSale";
            // 
            // tbPriceCate
            // 
            tbPriceCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbPriceCate.Location = new Point(621, 143);
            tbPriceCate.Name = "tbPriceCate";
            tbPriceCate.Size = new Size(220, 26);
            tbPriceCate.TabIndex = 19;
            // 
            // tbProdCate
            // 
            tbProdCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbProdCate.Location = new Point(814, 103);
            tbProdCate.Name = "tbProdCate";
            tbProdCate.Size = new Size(27, 26);
            tbProdCate.TabIndex = 18;
            tbProdCate.TextChanged += tbProdCate_TextChanged;
            // 
            // tbNameCate
            // 
            tbNameCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNameCate.Location = new Point(621, 69);
            tbNameCate.Name = "tbNameCate";
            tbNameCate.Size = new Size(220, 26);
            tbNameCate.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(534, 152);
            label7.Name = "label7";
            label7.Size = new Size(43, 19);
            label7.TabIndex = 16;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(534, 112);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 15;
            label8.Text = "Product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(534, 74);
            label9.Name = "label9";
            label9.Size = new Size(49, 19);
            label9.TabIndex = 14;
            label9.Text = "Name";
            // 
            // btnDeleCate
            // 
            btnDeleCate.ForeColor = Color.Crimson;
            btnDeleCate.Location = new Point(703, 352);
            btnDeleCate.Name = "btnDeleCate";
            btnDeleCate.Size = new Size(148, 46);
            btnDeleCate.TabIndex = 13;
            btnDeleCate.Text = "Delete";
            btnDeleCate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCate
            // 
            btnUpdateCate.Location = new Point(532, 352);
            btnUpdateCate.Name = "btnUpdateCate";
            btnUpdateCate.Size = new Size(148, 47);
            btnUpdateCate.TabIndex = 12;
            btnUpdateCate.Text = "Update";
            btnUpdateCate.UseVisualStyleBackColor = true;
            // 
            // btnAddCate
            // 
            btnAddCate.ForeColor = Color.Chartreuse;
            btnAddCate.Location = new Point(621, 5);
            btnAddCate.Name = "btnAddCate";
            btnAddCate.Size = new Size(148, 45);
            btnAddCate.TabIndex = 11;
            btnAddCate.Text = "Add Product";
            btnAddCate.UseVisualStyleBackColor = true;
            // 
            // drgCate
            // 
            drgCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgCate.Location = new Point(6, 5);
            drgCate.Name = "drgCate";
            drgCate.RowTemplate.Height = 25;
            drgCate.Size = new Size(520, 394);
            drgCate.TabIndex = 10;
            // 
            // tpPond
            // 
            tpPond.Location = new Point(4, 28);
            tpPond.Name = "tpPond";
            tpPond.Padding = new Padding(3);
            tpPond.Size = new Size(874, 441);
            tpPond.TabIndex = 3;
            tpPond.Text = "PondMana";
            tpPond.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // FAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 482);
            Controls.Add(Check);
            Name = "FAdmin";
            Text = "FAdmin";
            Check.ResumeLayout(false);
            tpCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpAccount.ResumeLayout(false);
            Product.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCpn).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drgProd).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drgCate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Check;
        private TabPage tpCheck;
        private TabPage tpFeed;
        private TabPage tpAccount;
        private TabPage tpPond;
        private Button btnSubmit;
        private DateTimePicker datetimeTo;
        private DateTimePicker datetimeFrom;
        private DataGridView dataGridView1;
        private ComboBox cbbPond;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btndelete;
        private Button btnUpdateCpn;
        private Button btnAddCompany;
        private DataGridView dgvCpn;
        private TextBox tbNameCpn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbRateCompany;
        private TextBox tbAddressCpn;
        private TabControl Product;
        private TabPage tabPage4;
        private TextBox textBox4;
        private TextBox tbCateProd;
        private TextBox tbNameProd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button btnAddProd;
        private DataGridView drgProd;
        private TextBox tbCpnProd;
        private Button btnDeleteProd;
        private Button btnUpdateProd;
        private Label Company;
        private TabPage tabPage5;
        private TextBox tbDecripCate;
        private TextBox tbProteinCate;
        private TextBox tbPridceSale;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbPriceCate;
        private TextBox tbProdCate;
        private TextBox tbNameCate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnDeleCate;
        private Button btnUpdateCate;
        private Button btnAddCate;
        private DataGridView drgCate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private TextBox tbShowCPN;
        private TextBox tbShowProd;
    }
}