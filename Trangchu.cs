using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void QuanliphongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form quanlyphong = new quanlyphong();
            this.Hide();
            quanlyphong.ShowDialog();
            this.Show();
        }

        private void ThongtincanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Thongtincanhan = new Thongtincanhan();
            this.Hide();
            Thongtincanhan.ShowDialog();
            this.Show();
        }

        private void DanhsachkhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form danhsachkhachhang = new danhsachkhachhang();
            this.Hide();
            danhsachkhachhang.ShowDialog();
            this.Show();
        }

        private void checkInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Checkin = new Checkin();
            this.Hide();
            Checkin.ShowDialog();
            this.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form checkout = new checkout();
            this.Hide();
            checkout.ShowDialog();
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Baocao = new Baocao();
            this.Hide();
            Baocao.ShowDialog();
            this.Show();
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dichvuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Dichvu= new Dichvu();    
            this.Hide();    
            Dichvu.ShowDialog();
            this.Show();
        }
    }
}
