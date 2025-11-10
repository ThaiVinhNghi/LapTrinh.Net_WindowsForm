namespace Buoi02_Bai_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double tong = a + b;
            MessageBox.Show("Tổng: " + tong);

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double hieu = a - b;
            MessageBox.Show("Hiệu: " + hieu);
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double tich = a * b;
            MessageBox.Show("Tích: " + tich);
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            if (b != 0)
            {
                double thuong = a / b;
                MessageBox.Show("Thương: " + thuong);
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể chia cho 0!");
            }
        }
    }
}
