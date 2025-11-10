namespace Buoi02_Bai_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang;
            string mua;

            // Kiểm tra nhập hợp lệ
            if (!int.TryParse(txtNhap.Text, out thang) || thang < 1 || thang > 12)
            {
                MessageBox.Show("Vui lòng nhập tháng từ 1 đến 12!", "Lỗi nhập liệu");
                return;
            }

            // Xác định mùa theo tháng
            if (thang == 12 || thang == 1 || thang == 2)
                mua = "Mùa Đông";
            else if (thang >= 3 && thang <= 5)
                mua = "Mùa Xuân";
            else if (thang >= 6 && thang <= 8)
                mua = "Mùa Hạ";
            else
                mua = "Mùa Thu";

            // Hiển thị kết quả
            MessageBox.Show("Tháng " + thang + " thuộc " + mua + ".", "Kết quả");
        }
    }
}