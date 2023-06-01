namespace ManegermentPond
{
    partial class Register
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
            panel1 = new Panel();
            panel5 = new Panel();
            BTNLogReg = new Button();
            BTExitReg = new Button();
            BTNReg = new Button();
            panel4 = new Panel();
            TBPassReg = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            TBDisplayReg = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            TBUserReg = new TextBox();
            LBUserReg = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 263);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(BTNLogReg);
            panel5.Controls.Add(BTExitReg);
            panel5.Controls.Add(BTNReg);
            panel5.Location = new Point(3, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(577, 52);
            panel5.TabIndex = 2;
            // 
            // BTNLogReg
            // 
            BTNLogReg.Location = new Point(49, 0);
            BTNLogReg.Name = "BTNLogReg";
            BTNLogReg.Size = new Size(155, 46);
            BTNLogReg.TabIndex = 2;
            BTNLogReg.Text = "Login";
            BTNLogReg.UseVisualStyleBackColor = true;
            // 
            // BTExitReg
            // 
            BTExitReg.Location = new Point(371, 0);
            BTExitReg.Name = "BTExitReg";
            BTExitReg.Size = new Size(155, 46);
            BTExitReg.TabIndex = 1;
            BTExitReg.Text = "Exit";
            BTExitReg.UseVisualStyleBackColor = true;
            // 
            // BTNReg
            // 
            BTNReg.Location = new Point(210, 0);
            BTNReg.Name = "BTNReg";
            BTNReg.Size = new Size(155, 46);
            BTNReg.TabIndex = 0;
            BTNReg.Text = "Register";
            BTNReg.UseVisualStyleBackColor = true;
            BTNReg.Click += BTNReg_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(TBPassReg);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 63);
            panel4.TabIndex = 4;
            // 
            // TBPassReg
            // 
            TBPassReg.Location = new Point(161, 16);
            TBPassReg.Name = "TBPassReg";
            TBPassReg.Size = new Size(372, 23);
            TBPassReg.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(TBDisplayReg);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 63);
            panel3.TabIndex = 1;
            // 
            // TBDisplayReg
            // 
            TBDisplayReg.Location = new Point(161, 16);
            TBDisplayReg.Name = "TBDisplayReg";
            TBDisplayReg.Size = new Size(372, 23);
            TBDisplayReg.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 2;
            label1.Text = "DisplayName";
            // 
            // panel2
            // 
            panel2.Controls.Add(TBUserReg);
            panel2.Controls.Add(LBUserReg);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 61);
            panel2.TabIndex = 0;
            // 
            // TBUserReg
            // 
            TBUserReg.Location = new Point(161, 18);
            TBUserReg.Name = "TBUserReg";
            TBUserReg.Size = new Size(372, 23);
            TBUserReg.TabIndex = 1;
            // 
            // LBUserReg
            // 
            LBUserReg.AutoSize = true;
            LBUserReg.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBUserReg.Location = new Point(15, 22);
            LBUserReg.Name = "LBUserReg";
            LBUserReg.Size = new Size(81, 19);
            LBUserReg.TabIndex = 0;
            LBUserReg.Text = "UserName";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 281);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private TextBox TBPassReg;
        private Label label2;
        private Panel panel3;
        private TextBox TBDisplayReg;
        private Label label1;
        private Panel panel2;
        private TextBox TBUserReg;
        private Label LBUserReg;
        private Panel panel5;
        private Button BTNLogReg;
        private Button BTExitReg;
        private Button BTNReg;
    }
}