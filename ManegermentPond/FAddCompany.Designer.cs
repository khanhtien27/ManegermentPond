namespace ManegermentPond
{
    partial class FAddCompany
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
            tbAddRess = new TextBox();
            tbNameAddCpn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddCompany = new Button();
            cbRateCPN = new ComboBox();
            SuspendLayout();
            // 
            // tbAddRess
            // 
            tbAddRess.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbAddRess.Location = new Point(116, 59);
            tbAddRess.Name = "tbAddRess";
            tbAddRess.Size = new Size(306, 26);
            tbAddRess.TabIndex = 15;
            // 
            // tbNameAddCpn
            // 
            tbNameAddCpn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNameAddCpn.Location = new Point(116, 12);
            tbNameAddCpn.Name = "tbNameAddCpn";
            tbNameAddCpn.Size = new Size(306, 26);
            tbNameAddCpn.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 116);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 13;
            label3.Text = "Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 12;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // btnAddCompany
            // 
            btnAddCompany.ForeColor = Color.Chartreuse;
            btnAddCompany.Location = new Point(281, 122);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(141, 36);
            btnAddCompany.TabIndex = 10;
            btnAddCompany.Text = "Add Company";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // cbRateCPN
            // 
            cbRateCPN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbRateCPN.FormattingEnabled = true;
            cbRateCPN.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbRateCPN.Location = new Point(116, 112);
            cbRateCPN.Name = "cbRateCPN";
            cbRateCPN.Size = new Size(97, 27);
            cbRateCPN.TabIndex = 17;
            // 
            // FAddCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 170);
            Controls.Add(cbRateCPN);
            Controls.Add(tbAddRess);
            Controls.Add(tbNameAddCpn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddCompany);
            Name = "FAddCompany";
            Text = "FAddCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddCompany;
        private ComboBox comboBox1;
        private ComboBox cbRateCPN;
        private TextBox tbAddRess;
        private TextBox tbNameAddCpn;
    }
}