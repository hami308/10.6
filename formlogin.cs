namespace GiaoDien_qlpks
{
    public partial class FormDangnhap : System.Windows.Forms.Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "THÔNG BÁO");
            }
            else
            {
                if ((textBox1.Text == "a") && (textBox2.Text == "1"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Form Trangchu = new Trangchu();
                    this.Hide();//ẩn cửa sổ hiện tại, cửa sổ chứa đoạn mã này
                    Trangchu.ShowDialog();
                    this.Show();//quay lại form bị ẩn bởi lệnh hide()
                }
                else
                    MessageBox.Show("Vui lòng nhập lại thông tin", "THÔNG BÁO");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}