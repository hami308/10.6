namespace GiaoDien_qlpks
{
    partial class checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            tabControl1 = new TabControl();
            tabthanhtoan = new TabPage();
            pictureBox1 = new PictureBox();
            Thanhtoan = new Button();
            Tongtien = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            tiendichvu = new TextBox();
            label5 = new Label();
            tienphong = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            songayluutru = new TextBox();
            label3 = new Label();
            textsophong = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            idphong = new TextBox();
            Timkiem = new Button();
            label2 = new Label();
            texttenkhach = new TextBox();
            label1 = new Label();
            tabcheckout = new TabPage();
            dtgvdanhsachthanhtoan = new DataGridView();
            chectout = new Button();
            idphongthanhtoan = new TextBox();
            button4 = new Button();
            tbmkh = new TextBox();
            button3 = new Button();
            tbidhoadon = new TextBox();
            button2 = new Button();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabthanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabcheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachthanhtoan).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabthanhtoan);
            tabControl1.Controls.Add(tabcheckout);
            tabControl1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabthanhtoan
            // 
            tabthanhtoan.BackColor = Color.MistyRose;
            tabthanhtoan.Controls.Add(pictureBox1);
            tabthanhtoan.Controls.Add(Thanhtoan);
            tabthanhtoan.Controls.Add(Tongtien);
            tabthanhtoan.Controls.Add(label7);
            tabthanhtoan.Controls.Add(panel3);
            tabthanhtoan.Controls.Add(panel2);
            tabthanhtoan.Controls.Add(panel1);
            tabthanhtoan.Location = new Point(4, 32);
            tabthanhtoan.Name = "tabthanhtoan";
            tabthanhtoan.Padding = new Padding(3);
            tabthanhtoan.Size = new Size(790, 404);
            tabthanhtoan.TabIndex = 0;
            tabthanhtoan.Text = "Thanh toán";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(573, 255);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Thanhtoan
            // 
            Thanhtoan.BackColor = Color.FromArgb(255, 128, 0);
            Thanhtoan.Location = new Point(399, 269);
            Thanhtoan.Name = "Thanhtoan";
            Thanhtoan.Size = new Size(121, 44);
            Thanhtoan.TabIndex = 5;
            Thanhtoan.Text = "Thanh toán";
            Thanhtoan.UseVisualStyleBackColor = false;
            // 
            // Tongtien
            // 
            Tongtien.Location = new Point(149, 277);
            Tongtien.Name = "Tongtien";
            Tongtien.Size = new Size(165, 31);
            Tongtien.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightCoral;
            label7.Location = new Point(9, 283);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 3;
            label7.Text = "Tổng";
            // 
            // panel3
            // 
            panel3.Controls.Add(tiendichvu);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tienphong);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(9, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 59);
            panel3.TabIndex = 2;
            // 
            // tiendichvu
            // 
            tiendichvu.Location = new Point(564, 16);
            tiendichvu.Name = "tiendichvu";
            tiendichvu.Size = new Size(165, 31);
            tiendichvu.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCoral;
            label5.Location = new Point(393, 16);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 2;
            label5.Text = "Tiền dịch vụ";
            // 
            // tienphong
            // 
            tienphong.Location = new Point(143, 16);
            tienphong.Name = "tienphong";
            tienphong.Size = new Size(165, 31);
            tienphong.TabIndex = 1;
            tienphong.TextChanged += tienphong_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 0;
            label6.Text = "Tiền phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(songayluutru);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textsophong);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(9, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 59);
            panel2.TabIndex = 1;
            // 
            // songayluutru
            // 
            songayluutru.Location = new Point(564, 13);
            songayluutru.Name = "songayluutru";
            songayluutru.Size = new Size(165, 31);
            songayluutru.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Location = new Point(393, 16);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Số Ngày Lưu Trú";
            // 
            // textsophong
            // 
            textsophong.Location = new Point(143, 13);
            textsophong.Name = "textsophong";
            textsophong.Size = new Size(165, 31);
            textsophong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 0;
            label4.Text = "Số phòng";
            // 
            // panel1
            // 
            panel1.Controls.Add(idphong);
            panel1.Controls.Add(Timkiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(texttenkhach);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 59);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // idphong
            // 
            idphong.Location = new Point(507, 13);
            idphong.Name = "idphong";
            idphong.Size = new Size(165, 31);
            idphong.TabIndex = 5;
            idphong.TextChanged += idphong_TextChanged;
            // 
            // Timkiem
            // 
            Timkiem.BackColor = Color.LightCoral;
            Timkiem.Location = new Point(691, 8);
            Timkiem.Name = "Timkiem";
            Timkiem.Size = new Size(75, 38);
            Timkiem.TabIndex = 4;
            Timkiem.Text = "Tìm";
            Timkiem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Location = new Point(393, 16);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "ID Phòng";
            label2.Click += label2_Click;
            // 
            // texttenkhach
            // 
            texttenkhach.Location = new Point(143, 13);
            texttenkhach.Name = "texttenkhach";
            texttenkhach.Size = new Size(165, 31);
            texttenkhach.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // tabcheckout
            // 
            tabcheckout.BackColor = Color.MistyRose;
            tabcheckout.Controls.Add(dtgvdanhsachthanhtoan);
            tabcheckout.Controls.Add(chectout);
            tabcheckout.Controls.Add(idphongthanhtoan);
            tabcheckout.Controls.Add(button4);
            tabcheckout.Controls.Add(tbmkh);
            tabcheckout.Controls.Add(button3);
            tabcheckout.Controls.Add(tbidhoadon);
            tabcheckout.Controls.Add(button2);
            tabcheckout.Controls.Add(button1);
            tabcheckout.Location = new Point(4, 32);
            tabcheckout.Name = "tabcheckout";
            tabcheckout.Padding = new Padding(3);
            tabcheckout.Size = new Size(790, 404);
            tabcheckout.TabIndex = 1;
            tabcheckout.Text = "Check out";
            // 
            // dtgvdanhsachthanhtoan
            // 
            dtgvdanhsachthanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvdanhsachthanhtoan.Location = new Point(8, 56);
            dtgvdanhsachthanhtoan.Name = "dtgvdanhsachthanhtoan";
            dtgvdanhsachthanhtoan.RowTemplate.Height = 25;
            dtgvdanhsachthanhtoan.Size = new Size(437, 334);
            dtgvdanhsachthanhtoan.TabIndex = 15;
            // 
            // chectout
            // 
            chectout.BackColor = Color.FromArgb(255, 192, 128);
            chectout.Location = new Point(600, 336);
            chectout.Name = "chectout";
            chectout.Size = new Size(119, 40);
            chectout.TabIndex = 14;
            chectout.Text = "Check out";
            chectout.UseVisualStyleBackColor = false;
            // 
            // idphongthanhtoan
            // 
            idphongthanhtoan.Location = new Point(600, 264);
            idphongthanhtoan.Name = "idphongthanhtoan";
            idphongthanhtoan.Size = new Size(194, 31);
            idphongthanhtoan.TabIndex = 13;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(451, 260);
            button4.Name = "button4";
            button4.Size = new Size(133, 39);
            button4.TabIndex = 12;
            button4.Text = "ID Phòng";
            button4.UseVisualStyleBackColor = false;
            // 
            // tbmkh
            // 
            tbmkh.Location = new Point(596, 168);
            tbmkh.Name = "tbmkh";
            tbmkh.Size = new Size(194, 31);
            tbmkh.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(451, 164);
            button3.Name = "button3";
            button3.Size = new Size(133, 39);
            button3.TabIndex = 10;
            button3.Text = "Mã khách hàng";
            button3.UseVisualStyleBackColor = false;
            // 
            // tbidhoadon
            // 
            tbidhoadon.Location = new Point(590, 72);
            tbidhoadon.Name = "tbidhoadon";
            tbidhoadon.Size = new Size(194, 31);
            tbidhoadon.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(451, 64);
            button2.Name = "button2";
            button2.Size = new Size(114, 44);
            button2.TabIndex = 8;
            button2.Text = "ID Hoá đơn";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(8, 6);
            button1.Name = "button1";
            button1.Size = new Size(437, 44);
            button1.TabIndex = 6;
            button1.Text = "Danh sách khách hàng đã thanh toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check out";
            tabControl1.ResumeLayout(false);
            tabthanhtoan.ResumeLayout(false);
            tabthanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabcheckout.ResumeLayout(false);
            tabcheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachthanhtoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabthanhtoan;
        private TabPage tabcheckout;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox texttenkhach;
        private Panel panel2;
        private TextBox songayluutru;
        private Label label3;
        private TextBox textsophong;
        private Label label4;
        private Button Timkiem;
        private TextBox idphong;
        private Label label7;
        private Panel panel3;
        private TextBox tiendichvu;
        private Label label5;
        private TextBox tienphong;
        private Label label6;
        private TextBox Tongtien;
        private Button Thanhtoan;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox idphongthanhtoan;
        private Button button4;
        private TextBox tbmkh;
        private Button button3;
        private TextBox tbidhoadon;
        private Button button2;
        private Button chectout;
        private DataGridView dtgvdanhsachthanhtoan;
    }
}