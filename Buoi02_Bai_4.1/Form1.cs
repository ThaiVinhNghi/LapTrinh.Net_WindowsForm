namespace Buoi02_Bai_4._1
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
            long s = 0;

            // Kiểm tra nhập hợp lệ
            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương n!", "Lỗi nhập liệu");
                return;
            }

            // Tính tổng S = 1 + 2 + ... + n
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }

            // Hoặc công thức: s = n * (n + 1) / 2;

            // Xuất kết quả ra ô txtKetQua
            txtKetQua.Text = s.ToString();
        }
    }
}
