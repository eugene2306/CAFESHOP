namespace CafeShop
{
    partial class AdminMainForm
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
            label6 = new Label();
            close = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 42);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 64, 0);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(259, 22);
            label6.TabIndex = 22;
            label6.Text = "Hệ thống quản lý quán cafe";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(111, 78, 55);
            close.Location = new Point(1464, 9);
            close.Name = "close";
            close.Size = new Size(24, 24);
            close.TabIndex = 20;
            close.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(111, 78, 55);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 748);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(79, 123);
            label1.Name = "label1";
            label1.Size = new Size(92, 24);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_cup;
            pictureBox1.Location = new Point(101, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 59);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(77, 54, 38);
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(25, 206);
            button1.Name = "button1";
            button1.Size = new Size(199, 53);
            button1.TabIndex = 15;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(77, 54, 38);
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(25, 279);
            button2.Name = "button2";
            button2.Size = new Size(199, 53);
            button2.TabIndex = 16;
            button2.Text = "Thêm nhân viên";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(77, 54, 38);
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(25, 353);
            button3.Name = "button3";
            button3.Size = new Size(199, 53);
            button3.TabIndex = 17;
            button3.Text = "Thêm sản phẩm";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(77, 54, 38);
            button4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Snow;
            button4.Location = new Point(25, 427);
            button4.Name = "button4";
            button4.Size = new Size(199, 53);
            button4.TabIndex = 18;
            button4.Text = "Khách hàng";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(77, 54, 38);
            button5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Snow;
            button5.Location = new Point(25, 665);
            button5.Name = "button5";
            button5.Size = new Size(199, 53);
            button5.TabIndex = 19;
            button5.Text = "Đăng xuất";
            button5.UseVisualStyleBackColor = false;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label close;
        private Label label1;
        private Label label6;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}