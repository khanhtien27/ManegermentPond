namespace ManegermentPond
{
    partial class Login
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
            panel3 = new Panel();
            TBPassword = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            TBUser = new TextBox();
            LBUser = new Label();
            panel4 = new Panel();
            Regis = new Button();
            BTExit = new Button();
            BTLogin = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 327);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(TBPassword);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(4, 117);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(829, 105);
            panel3.TabIndex = 1;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(230, 27);
            TBPassword.Margin = new Padding(4, 5, 4, 5);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(530, 31);
            TBPassword.TabIndex = 3;
            TBPassword.Text = "123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(TBUser);
            panel2.Controls.Add(LBUser);
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 102);
            panel2.TabIndex = 0;
            // 
            // TBUser
            // 
            TBUser.Location = new Point(230, 30);
            TBUser.Margin = new Padding(4, 5, 4, 5);
            TBUser.Name = "TBUser";
            TBUser.Size = new Size(530, 31);
            TBUser.TabIndex = 1;
            TBUser.Text = "khanhtien";
            TBUser.TextChanged += TBUser_TextChanged;
            // 
            // LBUser
            // 
            LBUser.AutoSize = true;
            LBUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LBUser.Location = new Point(21, 37);
            LBUser.Margin = new Padding(4, 0, 4, 0);
            LBUser.Name = "LBUser";
            LBUser.Size = new Size(119, 26);
            LBUser.TabIndex = 0;
            LBUser.Text = "UserName";
            // 
            // panel4
            // 
            panel4.Controls.Add(Regis);
            panel4.Controls.Add(BTExit);
            panel4.Controls.Add(BTLogin);
            panel4.Location = new Point(17, 252);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 87);
            panel4.TabIndex = 1;
            // 
            // Regis
            // 
            Regis.Location = new Point(143, 5);
            Regis.Margin = new Padding(4, 5, 4, 5);
            Regis.Name = "Regis";
            Regis.Size = new Size(221, 45);
            Regis.TabIndex = 2;
            Regis.Text = "Register";
            Regis.UseVisualStyleBackColor = true;
            Regis.Click += Regis_Click;
            // 
            // BTExit
            // 
            BTExit.Location = new Point(599, 5);
            BTExit.Margin = new Padding(4, 5, 4, 5);
            BTExit.Name = "BTExit";
            BTExit.Size = new Size(221, 45);
            BTExit.TabIndex = 1;
            BTExit.Text = "Exit";
            BTExit.UseVisualStyleBackColor = true;
            BTExit.Click += BTExit_Click;
            // 
            // BTLogin
            // 
            BTLogin.Location = new Point(373, 5);
            BTLogin.Margin = new Padding(4, 5, 4, 5);
            BTLogin.Name = "BTLogin";
            BTLogin.Size = new Size(221, 45);
            BTLogin.TabIndex = 0;
            BTLogin.Text = "Login";
            BTLogin.UseVisualStyleBackColor = true;
            BTLogin.Click += BTLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 352);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox TBUser;
        private Label LBUser;
        private TextBox TBPassword;
        private Label label1;
        private Button BTExit;
        private Button BTLogin;
        private Button Regis;
    }
}