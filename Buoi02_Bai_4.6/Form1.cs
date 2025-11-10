namespace Buoi02_Bai_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            double s = 0;

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương n!", "Lỗi nhập liệu");
                return;
            }

            // Tính S = 1 + 1/3 + 1/5 + ... + 1/(2n - 1)
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / (2 * i - 1);
            }

            // Hiển thị kết quả (làm tròn 4 chữ số thập phân)
            txtKetQua.Text = s.ToString("0.0000");
        }
    }
}
