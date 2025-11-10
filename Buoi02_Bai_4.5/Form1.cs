namespace Buoi02_Bai_4._5
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
            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương n!", "Lỗi nhập liệu");
                return;
            }

            // Cách 1: dùng vòng lặp
            for (int i = 1; i <= n; i++)
            {
                s += 2 * i;
            }

            // Cách 2 (ngắn gọn): s = n * (n + 1);
            // s = n * (n + 1);

            // Hiển thị kết quả
            txtKetQua.Text = s.ToString();
        }
    }
}

