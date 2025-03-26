namespace CafeShop
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            login_registerBtn = new Button();
            login_btn = new Button();
            login_showPass = new CheckBox();
            login_password = new TextBox();
            label4 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 78, 55);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(login_registerBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 484);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_cup;
            pictureBox1.Location = new Point(143, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 59);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(59, 201);
            label6.Name = "label6";
            label6.Size = new Size(210, 48);
            label6.TabIndex = 11;
            label6.Text = "HỆ THỐNG QUẢN LÝ\r\nQUÁN CAFE";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(98, 398);
            label5.Name = "label5";
            label5.Size = new Size(146, 24);
            label5.TabIndex = 10;
            label5.Text = "Tạo tài khoản";
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.FromArgb(111, 78, 55);
            login_registerBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = Color.Snow;
            login_registerBtn.Location = new Point(12, 425);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(317, 47);
            login_registerBtn.TabIndex = 9;
            login_registerBtn.Text = "ĐĂNG KÝ";
            login_registerBtn.UseVisualStyleBackColor = false;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(111, 78, 55);
            login_btn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Snow;
            login_btn.Location = new Point(378, 354);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(160, 43);
            login_btn.TabIndex = 26;
            login_btn.Text = "ĐĂNG NHẬP";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            login_showPass.Location = new Point(378, 282);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(160, 22);
            login_showPass.TabIndex = 25;
            login_showPass.Text = "Hiển thị mật khẩu";
            login_showPass.UseVisualStyleBackColor = true;
            // 
            // login_password
            // 
            login_password.Location = new Point(378, 249);
            login_password.Name = "login_password";
            login_password.Size = new Size(272, 27);
            login_password.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(378, 222);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 23;
            label4.Text = "Mật khẩu:";
            // 
            // login_username
            // 
            login_username.Location = new Point(378, 176);
            login_username.Name = "login_username";
            login_username.Size = new Size(272, 27);
            login_username.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(378, 149);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 21;
            label3.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(111, 78, 55);
            label2.Location = new Point(378, 97);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 20;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(111, 78, 55);
            close.Location = new Point(649, 9);
            close.Name = "close";
            close.Size = new Size(24, 24);
            close.TabIndex = 19;
            close.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 484);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Button login_registerBtn;
        private Button login_btn;
        private CheckBox login_showPass;
        private TextBox login_password;
        private Label label4;
        private TextBox login_username;
        private Label label3;
        private Label label2;
        private Label close;
    }
}