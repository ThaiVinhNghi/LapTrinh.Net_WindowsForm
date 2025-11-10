namespace Buoi02_Bai_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double tong = a + b;
            txtKetQua.Text = " " + tong;
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double hieu = a - b;
            txtKetQua.Text = " " + hieu;
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double tich = a * b;
            txtKetQua.Text = " " + tich;
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (b != 0)
            {
                double thuong = a / b;
                txtKetQua.Text = " " + thuong;
            }
            else
            {
                txtKetQua.Text = "Lỗi: Không thể chia cho 0!";
            }
        }
    }
}
