namespace Buoi02_Bai_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;
            bool hopLe = true;

            // Kiểm tra nhập số
            if (!int.TryParse(txtNgay.Text, out ngay) ||
                !int.TryParse(txtThang.Text, out thang) ||
                !int.TryParse(txtNam.Text, out nam))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu");
                return;
            }

            // Kiểm tra giới hạn tháng
            if (thang < 1 || thang > 12)
            {
                hopLe = false;
            }
            else
            {
                int soNgayTrongThang;

                // Xác định số ngày trong tháng
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        soNgayTrongThang = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        soNgayTrongThang = 30;
                        break;
                    case 2:
                        // Kiểm tra năm nhuận
                        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                            soNgayTrongThang = 29;
                        else
                            soNgayTrongThang = 28;
                        break;
                    default:
                        soNgayTrongThang = 0;
                        break;
                }

                // Kiểm tra ngày hợp lệ
                if (ngay < 1 || ngay > soNgayTrongThang)
                    hopLe = false;
            }

            // Thông báo kết quả
            if (hopLe)
                MessageBox.Show($"Ngày {ngay}/{thang}/{nam} là hợp lệ.", "Kết quả");
            else
                MessageBox.Show($"Ngày {ngay}/{thang}/{nam} KHÔNG hợp lệ!", "Kết quả");
        }
    }
}

