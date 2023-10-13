namespace GiaoDien_qlpks
{
    partial class Trangchu
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
            menuStrip1 = new MenuStrip();
            TaikhoancanhanToolStripMenuItem = new ToolStripMenuItem();
            ThongtincanhanToolStripMenuItem = new ToolStripMenuItem();
            DangxuatToolStripMenuItem = new ToolStripMenuItem();
            KhachhangToolStripMenuItem = new ToolStripMenuItem();
            DanhsachkhachhangToolStripMenuItem = new ToolStripMenuItem();
            checkInToolStripMenuItem1 = new ToolStripMenuItem();
            checkOutToolStripMenuItem = new ToolStripMenuItem();
            QuanliphongToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            dichvuToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._30;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 444);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TaikhoancanhanToolStripMenuItem, KhachhangToolStripMenuItem, QuanliphongToolStripMenuItem, báoCáoToolStripMenuItem, dichvuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TaikhoancanhanToolStripMenuItem
            // 
            TaikhoancanhanToolStripMenuItem.BackColor = Color.LightCoral;
            TaikhoancanhanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ThongtincanhanToolStripMenuItem, DangxuatToolStripMenuItem });
            TaikhoancanhanToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TaikhoancanhanToolStripMenuItem.Name = "TaikhoancanhanToolStripMenuItem";
            TaikhoancanhanToolStripMenuItem.Size = new Size(164, 29);
            TaikhoancanhanToolStripMenuItem.Text = "Tài khoản cá nhân";
            // 
            // ThongtincanhanToolStripMenuItem
            // 
            ThongtincanhanToolStripMenuItem.Name = "ThongtincanhanToolStripMenuItem";
            ThongtincanhanToolStripMenuItem.Size = new Size(226, 30);
            ThongtincanhanToolStripMenuItem.Text = "Thông tin cá nhân";
            ThongtincanhanToolStripMenuItem.Click += ThongtincanhanToolStripMenuItem_Click;
            // 
            // DangxuatToolStripMenuItem
            // 
            DangxuatToolStripMenuItem.Name = "DangxuatToolStripMenuItem";
            DangxuatToolStripMenuItem.Size = new Size(226, 30);
            DangxuatToolStripMenuItem.Text = "Đăng xuất";
            DangxuatToolStripMenuItem.Click += DangxuatToolStripMenuItem_Click;
            // 
            // KhachhangToolStripMenuItem
            // 
            KhachhangToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 192);
            KhachhangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhsachkhachhangToolStripMenuItem, checkInToolStripMenuItem1, checkOutToolStripMenuItem });
            KhachhangToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            KhachhangToolStripMenuItem.Name = "KhachhangToolStripMenuItem";
            KhachhangToolStripMenuItem.Size = new Size(116, 29);
            KhachhangToolStripMenuItem.Text = "Khách hàng";
            // 
            // DanhsachkhachhangToolStripMenuItem
            // 
            DanhsachkhachhangToolStripMenuItem.Name = "DanhsachkhachhangToolStripMenuItem";
            DanhsachkhachhangToolStripMenuItem.Size = new Size(262, 30);
            DanhsachkhachhangToolStripMenuItem.Text = "Danh sách khách hàng";
            DanhsachkhachhangToolStripMenuItem.Click += DanhsachkhachhangToolStripMenuItem_Click;
            // 
            // checkInToolStripMenuItem1
            // 
            checkInToolStripMenuItem1.Name = "checkInToolStripMenuItem1";
            checkInToolStripMenuItem1.Size = new Size(262, 30);
            checkInToolStripMenuItem1.Text = "Check in";
            checkInToolStripMenuItem1.Click += checkInToolStripMenuItem1_Click;
            // 
            // checkOutToolStripMenuItem
            // 
            checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            checkOutToolStripMenuItem.Size = new Size(262, 30);
            checkOutToolStripMenuItem.Text = "Check out";
            checkOutToolStripMenuItem.Click += checkOutToolStripMenuItem_Click;
            // 
            // QuanliphongToolStripMenuItem
            // 
            QuanliphongToolStripMenuItem.BackColor = Color.LightCoral;
            QuanliphongToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            QuanliphongToolStripMenuItem.Name = "QuanliphongToolStripMenuItem";
            QuanliphongToolStripMenuItem.Size = new Size(143, 29);
            QuanliphongToolStripMenuItem.Text = "Quản lý phòng";
            QuanliphongToolStripMenuItem.Click += QuanliphongToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 192);
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuToolStripMenuItem });
            báoCáoToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(87, 29);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(168, 30);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // dichvuToolStripMenuItem
            // 
            dichvuToolStripMenuItem.BackColor = Color.LightCoral;
            dichvuToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dichvuToolStripMenuItem.Name = "dichvuToolStripMenuItem";
            dichvuToolStripMenuItem.Size = new Size(114, 29);
            dichvuToolStripMenuItem.Text = "Các dịch vụ";
            dichvuToolStripMenuItem.Click += dichvuToolStripMenuItem_Click;
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Trangchu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TaikhoancanhanToolStripMenuItem;
        private ToolStripMenuItem ThongtincanhanToolStripMenuItem;
        private ToolStripMenuItem DangxuatToolStripMenuItem;
        private ToolStripMenuItem KhachhangToolStripMenuItem;
        private ToolStripMenuItem DanhsachkhachhangToolStripMenuItem;
        private ToolStripMenuItem checkInToolStripMenuItem1;
        private ToolStripMenuItem checkOutToolStripMenuItem;
        private ToolStripMenuItem QuanliphongToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem dichvuToolStripMenuItem;
    }
}