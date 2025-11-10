using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        // 🔹 Hàm tìm các số nguyên tố nhỏ hơn n
        List<int> CacSoNguyenToNhoHon(int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i < n; i++)
                if (LaSoNguyenTo(i))
                    list.Add(i);
            return list;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int n))
            {
                if (LaSoNguyenTo(n))
                    txtN1.Text = $"{n} là số nguyên tố";
                else
                    txtN1.Text = $"{n} không phải là số nguyên tố";

                List<int> ds = CacSoNguyenToNhoHon(n);
                txtN2.Text = string.Join(" ", ds);
            }
            else
            {
                txtN1.Clear();
                txtN2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtNhap.Focus();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
