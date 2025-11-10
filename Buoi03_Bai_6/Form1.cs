using System;
using System.Windows.Forms;

namespace Buoi03_Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                if (txtNhap.Text != "")
                {
                    lstTen.Items.Add(txtNhap.Text);
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
                else
                    MessageBox.Show("Vui lòng nhập tên trước khi thêm!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (lstTen.SelectedIndex != -1)
                    lstTen.Items.RemoveAt(lstTen.SelectedIndex);
                else
                    MessageBox.Show("Hãy chọn tên cần xóa!");
            }

        }

        private void lstTen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstTen.SelectedIndex != -1)
                txtKetQua.Text = lstTen.SelectedItem.ToString();
        }

        private void btnChonMauChu_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    txtKetQua.ForeColor = colorDialog1.Color;
            }
        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    txtKetQua.BackColor = colorDialog1.Color;
            }
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                    txtKetQua.Font = fontDialog1.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}