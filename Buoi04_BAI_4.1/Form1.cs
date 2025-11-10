using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_BAI_4._1
{
    public partial class Form1 : Form
    {
        List<int> mang = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mang.Clear();
            lblketqua.Text = "Đã xóa toàn bộ mảng.";
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int so = int.Parse(txtNhap.Text);
                mang.Add(so);
                lblketqua.Text = "Đã nhập: " + string.Join(", ", mang);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int so = int.Parse(txtNhap.Text);
                mang.Add(so);
                lblketqua.Text = "Đã nhập: " + string.Join(", ", mang);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lblketqua.Text = "Mảng hiện tại: " + string.Join(", ", mang);
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            mang.Sort();
            lblketqua.Text = "Mảng tăng dần: " + string.Join(", ", mang);
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            mang.Sort();
            mang.Reverse();
            lblketqua.Text = "Mảng giảm dần: " + string.Join(", ", mang);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            if (mang.Count == 0)
                lblketqua.Text = "Mảng rỗng!";
            else
                lblketqua.Text = "Tổng mảng = " + mang.Sum();
        }

        private void btnDiemSoChan_Click(object sender, EventArgs e)
        {
            int dem = mang.Count(x => x % 2 == 0);
            lblketqua.Text = "Số lượng số chẵn = " + dem;
        }

        private void btnDiemSoLe_Click(object sender, EventArgs e)
        {
            int dem = mang.Count(x => x % 2 != 0);
            lblketqua.Text = "Số lượng số lẻ = " + dem;
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            var snt = mang.Where(IsPrime).ToList();
            lblketqua.Text = "Các số nguyên tố: " + (snt.Count > 0 ? string.Join(", ", snt) : "Không có");
        }

        private void btnSoHoanHao_Click(object sender, EventArgs e)
        {
            
                var shh = mang.Where(IsPerfect).ToList();
                lblketqua.Text = "Các số hoàn hảo: " + (shh.Count > 0 ? string.Join(", ", shh) : "Không có");
            
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (mang.Count > 0)
                lblketqua.Text = "Trung bình mảng = " + mang.Average().ToString("0.##");
            else
                lblketqua.Text = "Mảng rỗng!";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (mang.Count > 0)
                lblketqua.Text = "Số nhỏ nhất = " + mang.Min();
            else
                lblketqua.Text = "Mảng rỗng!";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (mang.Count > 0)
                lblketqua.Text = "Số lớn nhất = " + mang.Max();
            else
                lblketqua.Text = "Mảng rỗng!";
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if (mang.Count < 2)
            {
                lblketqua.Text = "Cần ít nhất 2 phần tử để tính UCLN.";
                return;
            }

            int a = mang[0];
            int b = mang[1];
            lblketqua.Text = $"UCLN({a}, {b}) = {UCLN(a, b)}";
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private bool IsPerfect(int n)
        {
            if (n < 2) return false;
            int tong = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) tong += i;
            return tong == n;
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return Math.Abs(a);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblketqua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
