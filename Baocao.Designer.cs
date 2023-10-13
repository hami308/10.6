namespace GiaoDien_qlpks
{
    partial class Baocao
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
            ngayvao = new DateTimePicker();
            label2 = new Label();
            ngayra = new DateTimePicker();
            label3 = new Label();
            xembaocao = new Button();
            dtgvbaocao = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvbaocao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 28);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo doanh thu theo ngày";
            // 
            // ngayvao
            // 
            ngayvao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ngayvao.Location = new Point(124, 79);
            ngayvao.Name = "ngayvao";
            ngayvao.Size = new Size(227, 31);
            ngayvao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 2;
            label2.Text = "Từ ngày :";
            label2.Click += label2_Click;
            // 
            // ngayra
            // 
            ngayra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ngayra.Location = new Point(124, 135);
            ngayra.Name = "ngayra";
            ngayra.Size = new Size(227, 31);
            ngayra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 136);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 4;
            label3.Text = "Đến ngày :";
            // 
            // xembaocao
            // 
            xembaocao.BackColor = Color.FromArgb(255, 128, 128);
            xembaocao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xembaocao.Location = new Point(231, 196);
            xembaocao.Name = "xembaocao";
            xembaocao.Size = new Size(120, 36);
            xembaocao.TabIndex = 5;
            xembaocao.Text = "Xem báo cáo";
            xembaocao.UseVisualStyleBackColor = false;
            // 
            // dtgvbaocao
            // 
            dtgvbaocao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvbaocao.Location = new Point(372, 52);
            dtgvbaocao.Name = "dtgvbaocao";
            dtgvbaocao.RowTemplate.Height = 25;
            dtgvbaocao.Size = new Size(416, 386);
            dtgvbaocao.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._35;
            pictureBox1.Location = new Point(13, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Baocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(dtgvbaocao);
            Controls.Add(xembaocao);
            Controls.Add(label3);
            Controls.Add(ngayra);
            Controls.Add(label2);
            Controls.Add(ngayvao);
            Controls.Add(label1);
            Name = "Baocao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)dtgvbaocao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker ngayvao;
        private Label label2;
        private DateTimePicker ngayra;
        private Label label3;
        private Button xembaocao;
        private DataGridView dtgvbaocao;
        private PictureBox pictureBox1;
    }
}