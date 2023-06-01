namespace ManegermentPond
{
    partial class FIdentity
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
            btnChangePass = new Button();
            btnExit = new Button();
            btnChangeDPN = new Button();
            tbrole = new TextBox();
            tbdisplayname = new TextBox();
            tbUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChangePass);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnChangeDPN);
            panel1.Controls.Add(tbrole);
            panel1.Controls.Add(tbdisplayname);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 269);
            panel1.TabIndex = 0;
            // 
            // btnChangePass
            // 
            btnChangePass.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.Location = new Point(308, 213);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(123, 42);
            btnChangePass.TabIndex = 9;
            btnChangePass.Text = "ChangePW";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(442, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 42);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnChangeDPN
            // 
            btnChangeDPN.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeDPN.Location = new Point(171, 213);
            btnChangeDPN.Name = "btnChangeDPN";
            btnChangeDPN.Size = new Size(123, 42);
            btnChangeDPN.TabIndex = 7;
            btnChangeDPN.Text = "ChangeDPN";
            btnChangeDPN.UseVisualStyleBackColor = true;
            btnChangeDPN.Click += button1_Click;
            // 
            // tbrole
            // 
            tbrole.Location = new Point(171, 140);
            tbrole.Name = "tbrole";
            tbrole.ReadOnly = true;
            tbrole.Size = new Size(394, 35);
            tbrole.TabIndex = 6;
            // 
            // tbdisplayname
            // 
            tbdisplayname.Location = new Point(171, 83);
            tbdisplayname.Name = "tbdisplayname";
            tbdisplayname.Size = new Size(394, 35);
            tbdisplayname.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(171, 17);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(394, 35);
            tbUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 213);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 149);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(148, 26);
            label2.TabIndex = 1;
            label2.Text = "DisplayName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // FIdentity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 286);
            Controls.Add(panel1);
            Name = "FIdentity";
            Text = "FIdentity";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbrole;
        private TextBox tbdisplayname;
        private TextBox tbUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnChangePass;
        private Button btnExit;
        private Button btnChangeDPN;
    }
}