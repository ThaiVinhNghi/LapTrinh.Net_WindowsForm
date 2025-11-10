namespace Buoi02_Bai_4._4
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
            int s = 0;

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtN.Text, out n) || n < 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên n ≥ 0!", "Lỗi nhập liệu");
                return;
            }

            // Tính S = 1 + 3 + 5 + ... + (2n - 1) + (2n + 1)
            for (int i = 0; i <= n; i++)
            {
                s += 2 * i + 1;
            }

            // Hiển thị kết quả
            txtKetQua.Text = s.ToString();
        }
    }
}
