namespace GiaoDien_qlpks
{
    partial class danhsachkhachhang
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
            dataGridView1 = new DataGridView();
            xoa = new Button();
            chinhsua = new Button();
            them = new Button();
            panel2 = new Panel();
            tbtenkhachhang = new TextBox();
            panel7 = new Panel();
            tbidphong = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            tbtenkhach = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            tbmakhachhang = new TextBox();
            makhachhang = new Label();
            button1 = new Button();
            panel5 = new Panel();
            tbsđt = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            tbcccd = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(xoa);
            panel1.Controls.Add(chinhsua);
            panel1.Controls.Add(them);
            panel1.Location = new Point(12, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 422);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(401, 352);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // xoa
            // 
            xoa.BackColor = Color.FromArgb(255, 128, 128);
            xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xoa.Location = new Point(104, 0);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 42);
            xoa.TabIndex = 2;
            xoa.Text = "Xoá";
            xoa.UseVisualStyleBackColor = false;
            // 
            // chinhsua
            // 
            chinhsua.BackColor = Color.FromArgb(255, 128, 128);
            chinhsua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chinhsua.Location = new Point(213, 0);
            chinhsua.Name = "chinhsua";
            chinhsua.Size = new Size(105, 42);
            chinhsua.TabIndex = 1;
            chinhsua.Text = "Chỉnh sửa";
            chinhsua.UseVisualStyleBackColor = false;
            chinhsua.Click += chinhsua_Click;
            // 
            // them
            // 
            them.BackColor = Color.FromArgb(255, 128, 128);
            them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            them.Location = new Point(0, 0);
            them.Name = "them";
            them.Size = new Size(75, 42);
            them.TabIndex = 0;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(tbtenkhachhang);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(422, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 418);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // tbtenkhachhang
            // 
            tbtenkhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbtenkhachhang.Location = new Point(14, 13);
            tbtenkhachhang.Name = "tbtenkhachhang";
            tbtenkhachhang.Size = new Size(244, 29);
            tbtenkhachhang.TabIndex = 5;
            tbtenkhachhang.TextChanged += tbtenkhachhang_TextChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(tbidphong);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(0, 325);
            panel7.Name = "panel7";
            panel7.Size = new Size(377, 61);
            panel7.TabIndex = 4;
            // 
            // tbidphong
            // 
            tbidphong.Location = new Point(152, 16);
            tbidphong.Name = "tbidphong";
            tbidphong.Size = new Size(203, 23);
            tbidphong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 0;
            label4.Text = "ID phòng :";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbtenkhach);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 61);
            panel4.TabIndex = 3;
            // 
            // tbtenkhach
            // 
            tbtenkhach.Location = new Point(152, 16);
            tbtenkhach.Name = "tbtenkhach";
            tbtenkhach.Size = new Size(203, 23);
            tbtenkhach.TabIndex = 1;
            tbtenkhach.TextChanged += tbtenkhach_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng :";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbmakhachhang);
            panel3.Controls.Add(makhachhang);
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 61);
            panel3.TabIndex = 2;
            // 
            // tbmakhachhang
            // 
            tbmakhachhang.Location = new Point(152, 16);
            tbmakhachhang.Name = "tbmakhachhang";
            tbmakhachhang.ReadOnly = true;
            tbmakhachhang.Size = new Size(203, 23);
            tbmakhachhang.TabIndex = 1;
            tbmakhachhang.TextChanged += tbmakhachhang_TextChanged;
            // 
            // makhachhang
            // 
            makhachhang.AutoSize = true;
            makhachhang.BackColor = Color.FromArgb(255, 192, 192);
            makhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            makhachhang.Location = new Point(3, 16);
            makhachhang.Name = "makhachhang";
            makhachhang.Size = new Size(123, 21);
            makhachhang.TabIndex = 0;
            makhachhang.Text = "Mã khách hàng :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(264, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 1;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MistyRose;
            panel5.Controls.Add(tbsđt);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(425, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 52);
            panel5.TabIndex = 4;
            // 
            // tbsđt
            // 
            tbsđt.Location = new Point(152, 16);
            tbsđt.Name = "tbsđt";
            tbsđt.Size = new Size(203, 23);
            tbsđt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 0;
            label2.Text = "SĐT :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MistyRose;
            panel6.Controls.Add(tbcccd);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(422, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(377, 61);
            panel6.TabIndex = 4;
            // 
            // tbcccd
            // 
            tbcccd.Location = new Point(152, 16);
            tbcccd.Name = "tbcccd";
            tbcccd.Size = new Size(203, 23);
            tbcccd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 0;
            label3.Text = "CCCD :";
            // 
            // danhsachkhachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "danhsachkhachhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách khách hàng";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button xoa;
        private Button chinhsua;
        private Button them;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label makhachhang;
        private Button button1;
        private Panel panel4;
        private TextBox tbtenkhach;
        private Label label1;
        private TextBox tbmakhachhang;
        private Panel panel5;
        private TextBox tbsđt;
        private Label label2;
        private Panel panel6;
        private TextBox tbcccd;
        private Label label3;
        private Panel panel7;
        private TextBox tbidphong;
        private Label label4;
        private TextBox tbtenkhachhang;
    }
}