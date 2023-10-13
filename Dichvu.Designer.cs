namespace GiaoDien_qlpks
{
    partial class Dichvu
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
            label1 = new Label();
            panel1 = new Panel();
            dtgvdichvu = new DataGridView();
            panel2 = new Panel();
            tensanpham = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dongia = new TextBox();
            label3 = new Label();
            Them = new Button();
            xoa = new Button();
            btcapnhap = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdichvu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 3);
            label1.Name = "label1";
            label1.Size = new Size(251, 31);
            label1.TabIndex = 0;
            label1.Text = "Danh sách các dịch vụ :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvdichvu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 445);
            panel1.TabIndex = 1;
            // 
            // dtgvdichvu
            // 
            dtgvdichvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvdichvu.Location = new Point(3, 37);
            dtgvdichvu.Name = "dtgvdichvu";
            dtgvdichvu.RowTemplate.Height = 25;
            dtgvdichvu.Size = new Size(398, 405);
            dtgvdichvu.TabIndex = 1;
            dtgvdichvu.CellContentClick += dtgvdichvu_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(tensanpham);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(408, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 70);
            panel2.TabIndex = 2;
            // 
            // tensanpham
            // 
            tensanpham.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tensanpham.Location = new Point(171, 18);
            tensanpham.Name = "tensanpham";
            tensanpham.Size = new Size(208, 31);
            tensanpham.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dongia);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(408, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 72);
            panel3.TabIndex = 3;
            // 
            // dongia
            // 
            dongia.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dongia.Location = new Point(171, 18);
            dongia.Name = "dongia";
            dongia.Size = new Size(208, 31);
            dongia.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 0;
            label3.Text = "Đơn giá :";
            // 
            // Them
            // 
            Them.BackColor = Color.FromArgb(255, 128, 128);
            Them.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Them.Location = new Point(444, 304);
            Them.Name = "Them";
            Them.Size = new Size(75, 39);
            Them.TabIndex = 4;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = false;
            // 
            // xoa
            // 
            xoa.BackColor = Color.FromArgb(255, 128, 128);
            xoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            xoa.Location = new Point(701, 304);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 39);
            xoa.TabIndex = 5;
            xoa.Text = "Xoá";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // btcapnhap
            // 
            btcapnhap.BackColor = Color.FromArgb(255, 128, 128);
            btcapnhap.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btcapnhap.Location = new Point(558, 304);
            btcapnhap.Name = "btcapnhap";
            btcapnhap.Size = new Size(105, 39);
            btcapnhap.TabIndex = 6;
            btcapnhap.Text = "Cập nhật";
            btcapnhap.UseVisualStyleBackColor = false;
            btcapnhap.Click += btcapnhap_Click;
            // 
            // Dichvu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(797, 450);
            Controls.Add(btcapnhap);
            Controls.Add(xoa);
            Controls.Add(Them);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dichvu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ";
            Load += Dichvu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdichvu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dtgvdichvu;
        private Panel panel2;
        private Label label2;
        private TextBox tensanpham;
        private Panel panel3;
        private TextBox dongia;
        private Label label3;
        private Button Them;
        private Button xoa;
        private Button btcapnhap;
    }
}