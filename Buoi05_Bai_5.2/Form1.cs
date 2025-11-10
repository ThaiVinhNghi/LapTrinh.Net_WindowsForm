using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhap.Text, out int n))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu");
                return;
            }

            if (LaSoHoanHao(n))
                MessageBox.Show($"{n} là số hoàn hảo.", "Kết quả");
            else
                MessageBox.Show($"{n} không phải là số hoàn hảo.", "Kết quả");
        }
    }
}
