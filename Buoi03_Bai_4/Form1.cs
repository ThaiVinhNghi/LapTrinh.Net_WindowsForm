using System;
using System.Windows.Forms;

namespace Buoi03_Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdothuong.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToLower();
                }
                if (this.rdohoa.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToUpper();
                }
            }
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdothuong.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToLower();
                }
                if (this.rdohoa.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToUpper();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click_1(object sender, EventArgs e)
        {

            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdothuong.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToLower();
                }
                if (this.rdohoa.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToUpper();
                }
            }
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdothuong.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToLower();
                }
                if (this.rdohoa.Checked == true)
                {
                    this.txtKetQua.Text = hoten.ToUpper();
                }
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
