namespace GiaoDien_qlpks
{
    partial class FormDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangnhap));
            nhapMatkhau = new Label();
            nhapten = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Dangnhap = new Button();
            Dong = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // nhapMatkhau
            // 
            nhapMatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhapMatkhau.AutoSize = true;
            nhapMatkhau.BackColor = SystemColors.ButtonHighlight;
            nhapMatkhau.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            nhapMatkhau.Location = new Point(134, 268);
            nhapMatkhau.Name = "nhapMatkhau";
            nhapMatkhau.Size = new Size(104, 28);
            nhapMatkhau.TabIndex = 2;
            nhapMatkhau.Text = "Mật Khẩu";
            nhapMatkhau.Click += label2_Click;
            // 
            // nhapten
            // 
            nhapten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhapten.AutoSize = true;
            nhapten.BackColor = SystemColors.Control;
            nhapten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            nhapten.Location = new Point(134, 174);
            nhapten.Name = "nhapten";
            nhapten.Size = new Size(158, 28);
            nhapten.TabIndex = 2;
            nhapten.Text = "Tên Đăng Nhập";
            nhapten.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(319, 174);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(319, 268);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 4;
            // 
            // Dangnhap
            // 
            Dangnhap.BackColor = SystemColors.ButtonHighlight;
            Dangnhap.FlatAppearance.BorderColor = Color.Blue;
            Dangnhap.FlatAppearance.MouseDownBackColor = Color.Cyan;
            Dangnhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            Dangnhap.FlatStyle = FlatStyle.Flat;
            Dangnhap.Location = new Point(304, 344);
            Dangnhap.Name = "Dangnhap";
            Dangnhap.Size = new Size(113, 46);
            Dangnhap.TabIndex = 5;
            Dangnhap.Text = "Đăng nhập";
            Dangnhap.UseVisualStyleBackColor = false;
            Dangnhap.Click += button2_Click;
            // 
            // Dong
            // 
            Dong.BackColor = SystemColors.Control;
            Dong.FlatAppearance.MouseDownBackColor = Color.Red;
            Dong.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Dong.FlatStyle = FlatStyle.Flat;
            Dong.Location = new Point(487, 344);
            Dong.Name = "Dong";
            Dong.Size = new Size(103, 46);
            Dong.TabIndex = 6;
            Dong.Text = "Đóng";
            Dong.UseVisualStyleBackColor = false;
            Dong.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 44F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 78);
            label1.TabIndex = 7;
            label1.Text = "Đăng nhập";
            // 
            // FormDangnhap
            // 
            AcceptButton = Dangnhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(696, 439);
            Controls.Add(label1);
            Controls.Add(Dong);
            Controls.Add(Dangnhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nhapten);
            Controls.Add(nhapMatkhau);
            DoubleBuffered = true;
            Name = "FormDangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng Khách Sạn";
            Load += FormDangnhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nhapMatkhau;
        private Label nhapten;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Dangnhap;
        private Button Dong;
        private Label label1;
    }
}