namespace GiaoDien_qlpks
{
    partial class Thongtincanhan
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
            thoat = new Button();
            capnhap = new Button();
            panel2 = new Panel();
            tendangnhap1 = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            matkhaucu = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            tenhienthi = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel6 = new Panel();
            matkhaumoi = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(thoat);
            panel1.Controls.Add(capnhap);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 426);
            panel1.TabIndex = 0;
            // 
            // thoat
            // 
            thoat.BackColor = Color.FromArgb(255, 192, 192);
            thoat.FlatAppearance.MouseDownBackColor = Color.Cyan;
            thoat.FlatAppearance.MouseOverBackColor = Color.Red;
            thoat.FlatStyle = FlatStyle.Flat;
            thoat.Font = new Font("Segoe UI Variable Text Light", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            thoat.Location = new Point(467, 375);
            thoat.Name = "thoat";
            thoat.Size = new Size(98, 39);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // capnhap
            // 
            capnhap.BackColor = Color.FromArgb(255, 192, 192);
            capnhap.FlatAppearance.MouseDownBackColor = Color.Cyan;
            capnhap.FlatAppearance.MouseOverBackColor = Color.Red;
            capnhap.FlatStyle = FlatStyle.Flat;
            capnhap.Font = new Font("Segoe UI Variable Text Light", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            capnhap.Location = new Point(283, 375);
            capnhap.Name = "capnhap";
            capnhap.Size = new Size(107, 39);
            capnhap.TabIndex = 5;
            capnhap.Text = "Cập nhập";
            capnhap.UseVisualStyleBackColor = false;
            capnhap.Click += capnhap_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(tendangnhap1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 71);
            panel2.TabIndex = 0;
            // 
            // tendangnhap1
            // 
            tendangnhap1.Location = new Point(220, 26);
            tendangnhap1.Name = "tendangnhap1";
            tendangnhap1.Size = new Size(345, 23);
            tendangnhap1.TabIndex = 3;
            tendangnhap1.TextChanged += tendangnhap1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MistyRose;
            panel5.Controls.Add(matkhaucu);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(12, 229);
            panel5.Name = "panel5";
            panel5.Size = new Size(605, 71);
            panel5.TabIndex = 3;
            // 
            // matkhaucu
            // 
            matkhaucu.AutoSize = true;
            matkhaucu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaucu.Location = new Point(15, 13);
            matkhaucu.Name = "matkhaucu";
            matkhaucu.Size = new Size(135, 28);
            matkhaucu.TabIndex = 2;
            matkhaucu.Text = "Mật khẩu cũ:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 23);
            textBox2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tenhienthi);
            panel3.Location = new Point(12, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(605, 60);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị :";
            // 
            // tenhienthi
            // 
            tenhienthi.Location = new Point(220, 18);
            tenhienthi.Name = "tenhienthi";
            tenhienthi.Size = new Size(347, 23);
            tenhienthi.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCoral;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(12, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(605, 68);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 10);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCoral;
            panel6.Controls.Add(matkhaumoi);
            panel6.Controls.Add(textBox3);
            panel6.Location = new Point(12, 306);
            panel6.Name = "panel6";
            panel6.Size = new Size(605, 71);
            panel6.TabIndex = 3;
            // 
            // matkhaumoi
            // 
            matkhaumoi.AutoSize = true;
            matkhaumoi.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaumoi.Location = new Point(15, 18);
            matkhaumoi.Name = "matkhaumoi";
            matkhaumoi.Size = new Size(156, 28);
            matkhaumoi.TabIndex = 2;
            matkhaumoi.Text = " Mật khẩu mới:";
            matkhaumoi.Click += matkhaumoi_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 23);
            textBox3.TabIndex = 1;
            // 
            // Thongtincanhan
            // 
            AcceptButton = capnhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = thoat;
            ClientSize = new Size(634, 450);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Thongtincanhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thongtincanhan";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Label matkhaumoi;
        private TextBox textBox3;
        private Panel panel4;
        private Panel panel5;
        private Label matkhaucu;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private TextBox tenhienthi;
        public Button capnhap;
        public Button thoat;
        private TextBox tendangnhap1;
    }
}