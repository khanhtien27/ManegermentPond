namespace ManegermentPond
{
    partial class FChangePassword
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
            tbReNewPass = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            tbNewpass = new TextBox();
            tbPassword = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbReNewPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(tbNewpass);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 232);
            panel1.TabIndex = 1;
            // 
            // tbReNewPass
            // 
            tbReNewPass.Location = new Point(184, 131);
            tbReNewPass.Name = "tbReNewPass";
            tbReNewPass.Size = new Size(394, 35);
            tbReNewPass.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 134);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 10;
            label3.Text = "Retype";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(296, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(455, 179);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 42);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbNewpass
            // 
            tbNewpass.Location = new Point(184, 77);
            tbNewpass.Name = "tbNewpass";
            tbNewpass.Size = new Size(394, 35);
            tbNewpass.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(184, 20);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(394, 35);
            tbPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 213);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(161, 26);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // FChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 245);
            Controls.Add(panel1);
            Name = "FChangePassword";
            Text = "FChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private Button btnExit;
        private Button btnChangeDPN;
        private TextBox tbNewpass;
        private TextBox tbPassword;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox tbReNewPass;
        private Label label3;
    }
}