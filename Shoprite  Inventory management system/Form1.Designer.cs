namespace Shoprite__Inventory_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.RoleCb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PassTb);
            this.panel1.Controls.Add(this.UsernameTb);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Location = new System.Drawing.Point(571, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 441);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Role";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(85, 146);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(88, 22);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // RoleCb
            // 
            this.RoleCb.BackColor = System.Drawing.Color.White;
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.RoleCb.Location = new System.Drawing.Point(232, 26);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(124, 30);
            this.RoleCb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(104, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassTb
            // 
            this.PassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassTb.ForeColor = System.Drawing.Color.Black;
            this.PassTb.Location = new System.Drawing.Point(85, 248);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(213, 30);
            this.PassTb.TabIndex = 2;
            this.PassTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UsernameTb
            // 
            this.UsernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTb.ForeColor = System.Drawing.Color.Black;
            this.UsernameTb.Location = new System.Drawing.Point(85, 171);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(213, 30);
            this.UsernameTb.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(136, 81);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(80, 33);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOM TO SHOPRITE\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "INVENTORY SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(120, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 120);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 120);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "INVENTORY SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(34, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "WELCOME TO SHOPRITE\r\n";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(989, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 513);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Login;
        private Label label1;
        private TextBox PassTb;
        private TextBox UsernameTb;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private ComboBox RoleCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button4;
        private Label Username;
        private Label label6;
        private Label label5;
    }
}