namespace ManegermentPond
{
    partial class FChangeDisplayName
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
            tbreass = new TextBox();
            label5 = new Label();
            btnupdate = new Button();
            btnexit = new Button();
            tbpass = new TextBox();
            tbnewdisplay = new TextBox();
            tbDisplay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbreass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnupdate);
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(tbpass);
            panel1.Controls.Add(tbnewdisplay);
            panel1.Controls.Add(tbDisplay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(105, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 310);
            panel1.TabIndex = 1;
            // 
            // tbreass
            // 
            tbreass.Location = new Point(171, 204);
            tbreass.Name = "tbreass";
            tbreass.Size = new Size(394, 35);
            tbreass.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 213);
            label5.Name = "label5";
            label5.Size = new Size(138, 26);
            label5.TabIndex = 10;
            label5.Text = "RePassword";
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdate.Location = new Point(297, 256);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(123, 42);
            btnupdate.TabIndex = 9;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(442, 256);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(123, 42);
            btnexit.TabIndex = 8;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(171, 140);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(394, 35);
            tbpass.TabIndex = 6;
            // 
            // tbnewdisplay
            // 
            tbnewdisplay.Location = new Point(171, 83);
            tbnewdisplay.Name = "tbnewdisplay";
            tbnewdisplay.Size = new Size(394, 35);
            tbnewdisplay.TabIndex = 5;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(171, 17);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(394, 35);
            tbDisplay.TabIndex = 4;
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
            label3.Size = new Size(110, 26);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 1;
            label2.Text = "New";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(148, 26);
            label1.TabIndex = 0;
            label1.Text = "DisplayName";
            // 
            // FChangeDisplayName
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 324);
            Controls.Add(panel1);
            Name = "FChangeDisplayName";
            Text = "FChangeDisplayName";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbreass;
        private Label label5;
        private Button btnupdate;
        private Button btnexit;
        private TextBox tbpass;
        private TextBox tbnewdisplay;
        private TextBox tbDisplay;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}