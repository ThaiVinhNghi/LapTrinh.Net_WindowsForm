using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_4._3
{
    public partial class Form1 : Form
    {
        int[] a;
        public Form1()
        {
            InitializeComponent();
            btnSum.Enabled = false;
            btnMax.Enabled = false;
        }

        private void btnTaomang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Hãy nhập số phần tử mảng!");
                txtNhap.Focus();
                return;
            }

            if (!int.TryParse(txtNhap.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Số phần tử phải > 0!");
                txtNhap.Focus();
                return;
            }

            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(-10, 100);

            MessageBox.Show("Mảng vừa tạo: " + string.Join(", ", a));
            btnSum.Enabled = true;
            btnMax.Enabled = true;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (a == null) { MessageBox.Show("Bạn cần tạo mảng trước!"); return; }

            var result = MessageBox.Show("Bạn có muốn xem tổng mảng không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 f2 = new Form2(a);
                f2.ShowDialog();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (a == null) { MessageBox.Show("Bạn cần tạo mảng trước!"); return; }

            var result = MessageBox.Show("Bạn có muốn xem số lớn nhất không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form3 f3 = new Form3(a);
                f3.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
