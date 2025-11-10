namespace Buoi02_Bai_4._7
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
            long s = 1; // dùng long để chứa kết quả lớn

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtN.Text, out n) || n < 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm n!", "Lỗi nhập liệu");
                return;
            }

            // Tính giai thừa: S = 1 * 2 * 3 * ... * n
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }

            // Hiển thị kết quả
            txtKetQua.Text = s.ToString();
        }
    }
}


