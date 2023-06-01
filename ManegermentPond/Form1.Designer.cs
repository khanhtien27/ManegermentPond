namespace ManegermentPond
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpPond = new FlowLayoutPanel();
            cbbCty = new ComboBox();
            cbbProd = new ComboBox();
            cbbCate = new ComboBox();
            Number = new NumericUpDown();
            btnAdd = new Button();
            btnDetail = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            tbTotalPrice = new TextBox();
            btnTotal = new Button();
            cbbChangePond = new ComboBox();
            bntchangePond = new Button();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            IdentityToolStrip = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Number).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flpPond
            // 
            flpPond.AutoScroll = true;
            flpPond.Location = new Point(17, 112);
            flpPond.Margin = new Padding(4, 5, 4, 5);
            flpPond.Name = "flpPond";
            flpPond.Size = new Size(560, 618);
            flpPond.TabIndex = 0;
            // 
            // cbbCty
            // 
            cbbCty.FormattingEnabled = true;
            cbbCty.Location = new Point(586, 63);
            cbbCty.Margin = new Padding(4, 5, 4, 5);
            cbbCty.Name = "cbbCty";
            cbbCty.Size = new Size(180, 33);
            cbbCty.TabIndex = 1;
            cbbCty.SelectedIndexChanged += cbbCty_SelectedIndexChanged;
            // 
            // cbbProd
            // 
            cbbProd.FormattingEnabled = true;
            cbbProd.Location = new Point(586, 112);
            cbbProd.Margin = new Padding(4, 5, 4, 5);
            cbbProd.Name = "cbbProd";
            cbbProd.Size = new Size(328, 33);
            cbbProd.TabIndex = 2;
            cbbProd.SelectedIndexChanged += cbbProd_SelectedIndexChanged;
            // 
            // cbbCate
            // 
            cbbCate.FormattingEnabled = true;
            cbbCate.Location = new Point(586, 160);
            cbbCate.Margin = new Padding(4, 5, 4, 5);
            cbbCate.Name = "cbbCate";
            cbbCate.Size = new Size(328, 33);
            cbbCate.TabIndex = 3;
            // 
            // Number
            // 
            Number.Location = new Point(797, 63);
            Number.Margin = new Padding(4, 5, 4, 5);
            Number.Name = "Number";
            Number.Size = new Size(119, 31);
            Number.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(967, 63);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 87);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(967, 160);
            btnDetail.Margin = new Padding(4, 5, 4, 5);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(159, 38);
            btnDetail.TabIndex = 7;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView.GridLines = true;
            listView.Location = new Point(586, 208);
            listView.Margin = new Padding(4, 5, 4, 5);
            listView.Name = "listView";
            listView.Size = new Size(538, 436);
            listView.TabIndex = 8;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Number";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product's Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category's Name";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Decription";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Protein";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Rate";
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tbTotalPrice.Location = new Point(836, 687);
            tbTotalPrice.Margin = new Padding(4, 5, 4, 5);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.ReadOnly = true;
            tbTotalPrice.Size = new Size(165, 35);
            tbTotalPrice.TabIndex = 9;
            tbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotal.Location = new Point(1039, 677);
            btnTotal.Margin = new Padding(4, 5, 4, 5);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(87, 63);
            btnTotal.TabIndex = 10;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // cbbChangePond
            // 
            cbbChangePond.FormattingEnabled = true;
            cbbChangePond.Location = new Point(599, 702);
            cbbChangePond.Margin = new Padding(4, 5, 4, 5);
            cbbChangePond.Name = "cbbChangePond";
            cbbChangePond.Size = new Size(153, 33);
            cbbChangePond.TabIndex = 11;
            // 
            // bntchangePond
            // 
            bntchangePond.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntchangePond.Location = new Point(599, 655);
            bntchangePond.Margin = new Padding(4, 5, 4, 5);
            bntchangePond.Name = "bntchangePond";
            bntchangePond.Size = new Size(154, 37);
            bntchangePond.TabIndex = 12;
            bntchangePond.Text = "ChangePond";
            bntchangePond.UseVisualStyleBackColor = true;
            bntchangePond.Click += bntchangePond_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, IdentityToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // IdentityToolStrip
            // 
            IdentityToolStrip.Name = "IdentityToolStrip";
            IdentityToolStrip.Size = new Size(88, 29);
            IdentityToolStrip.Text = "Identity";
            IdentityToolStrip.Click += IdentityToolStrip_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(bntchangePond);
            Controls.Add(cbbChangePond);
            Controls.Add(btnTotal);
            Controls.Add(tbTotalPrice);
            Controls.Add(listView);
            Controls.Add(btnDetail);
            Controls.Add(btnAdd);
            Controls.Add(Number);
            Controls.Add(cbbCate);
            Controls.Add(cbbProd);
            Controls.Add(cbbCty);
            Controls.Add(flpPond);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FMain";
            Text = "ManegermentPond Design By KhanhTien";
            ((System.ComponentModel.ISupportInitialize)Number).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpPond;
        private ComboBox cbbCty;
        private ComboBox cbbProd;
        private ComboBox cbbCate;
        private NumericUpDown Number;
        private Button btnAdd;
        private Button btnDetail;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox tbTotalPrice;
        private Button btnTotal;
        private ComboBox cbbChangePond;
        private Button bntchangePond;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem IdentityToolStrip;
    }
}