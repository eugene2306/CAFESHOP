namespace CafeShop
{
    partial class RegisterForm
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
            register_loginBtn = new Button();
            close = new Label();
            register_btn = new Button();
            register_showPass = new CheckBox();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            register_cPassword = new TextBox();
            label7 = new Label();
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
            panel1.Controls.Add(register_loginBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 484);
            panel1.TabIndex = 1;
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
            label5.Location = new Point(59, 398);
            label5.Name = "label5";
            label5.Size = new Size(220, 24);
            label5.TabIndex = 10;
            label5.Text = "Bạn đã có tài khoản?";
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.FromArgb(111, 78, 55);
            register_loginBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = Color.Snow;
            register_loginBtn.Location = new Point(12, 425);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(317, 47);
            register_loginBtn.TabIndex = 9;
            register_loginBtn.Text = "ĐĂNG NHẬP";
            register_loginBtn.UseVisualStyleBackColor = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(111, 78, 55);
            close.Location = new Point(649, 9);
            close.Name = "close";
            close.Size = new Size(24, 24);
            close.TabIndex = 9;
            close.Text = "X";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(111, 78, 55);
            register_btn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.Snow;
            register_btn.Location = new Point(374, 375);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(160, 43);
            register_btn.TabIndex = 16;
            register_btn.Text = "ĐĂNG KÝ";
            register_btn.UseVisualStyleBackColor = false;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            register_showPass.Location = new Point(374, 327);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(160, 22);
            register_showPass.TabIndex = 15;
            register_showPass.Text = "Hiển thị mật khẩu";
            register_showPass.UseVisualStyleBackColor = true;
            // 
            // register_password
            // 
            register_password.Location = new Point(374, 218);
            register_password.Name = "register_password";
            register_password.Size = new Size(272, 27);
            register_password.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(374, 191);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 13;
            label4.Text = "Mật khẩu:";
            // 
            // register_username
            // 
            register_username.Location = new Point(374, 145);
            register_username.Name = "register_username";
            register_username.Size = new Size(272, 27);
            register_username.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(374, 118);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 11;
            label3.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(111, 78, 55);
            label2.Location = new Point(374, 66);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 10;
            label2.Text = "ĐĂNG KÝ";
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(374, 294);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.Size = new Size(272, 27);
            register_cPassword.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(374, 267);
            label7.Name = "label7";
            label7.Size = new Size(180, 21);
            label7.TabIndex = 17;
            label7.Text = "Xác nhận mật khẩu:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 484);
            Controls.Add(register_cPassword);
            Controls.Add(label7);
            Controls.Add(register_btn);
            Controls.Add(register_showPass);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
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
        private Button register_loginBtn;
        private Label close;
        private Button register_btn;
        private CheckBox register_showPass;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private TextBox register_cPassword;
        private Label label7;
    }
}