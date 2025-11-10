namespace Buoi02_Bai_4._2
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

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương n!", "Lỗi nhập liệu");
                return;
            }

            // Tính S = 1^2 + 2^2 + ... + n^2
            for (int i = 1; i <= n; i++)
            {
                s += i * i;
            }

            // Hiển thị kết quả
            txtKetQua.Text = s.ToString();
        }
    }
}
