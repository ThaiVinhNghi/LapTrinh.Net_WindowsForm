using System;
using System.Drawing;
using System.Windows.Forms;

namespace Buoi03_Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienLoIChao_Click(object sender, EventArgs e)
        {
            {
                string ten = "";

                // Nếu có chọn trong danh sách thì lấy SelectedItem
                if (cboHoTen.SelectedItem != null)
                    ten = cboHoTen.SelectedItem.ToString();
                else
                    // Nếu người dùng tự gõ vào thì lấy Text
                    ten = cboHoTen.Text;

                // Kiểm tra nếu người dùng chưa nhập hay chưa chọn gì
                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xuất lời chào
                MessageBox.Show($"Chào {ten}, chúc một ngày vui vẻ!", "Lời chào", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHienLoIChao_Click_1(object sender, EventArgs e)
        {
            {
                string ten = "";

                // Nếu có chọn trong danh sách thì lấy SelectedItem
                if (cboHoTen.SelectedItem != null)
                    ten = cboHoTen.SelectedItem.ToString();
                else
                    // Nếu người dùng tự gõ vào thì lấy Text
                    ten = cboHoTen.Text;

                // Kiểm tra nếu người dùng chưa nhập hay chưa chọn gì
                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xuất lời chào
                MessageBox.Show($"Chào {ten}, chúc một ngày vui vẻ!", "Lời chào", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}