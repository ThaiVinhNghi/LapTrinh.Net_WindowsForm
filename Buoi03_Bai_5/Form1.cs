using System;
using System.Windows.Forms;

namespace Buoi03_Bai_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int TimMax(int so1, int so2)
        {
            if (so1 < so2)
                return so2;
            else
                return so1;
        }
        public string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    chuoi += i.ToString() + "  ";
            }
            return chuoi;
        }
        public int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }


        private void btnTinh_Click(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtN.Text);
                int m = int.Parse(txtM.Text);

                if (rdo1.Checked)
                    txtKetQua.Text = TimUocChung(n, m);
                else if (rdo2.Checked)
                    txtKetQua.Text = TimUCLN(n, m).ToString();
                else
                    MessageBox.Show("Vui lòng chọn phép tính!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                txtN.Clear();
                txtM.Clear();
                txtKetQua.Clear();
                txtN.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click_1(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtN.Text);
                int m = int.Parse(txtM.Text);

                if (rdo1.Checked)
                    txtKetQua.Text = TimUocChung(n, m);
                else if (rdo2.Checked)
                    txtKetQua.Text = TimUCLN(n, m).ToString();
                else
                    MessageBox.Show("Vui lòng chọn phép tính!");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            {
                txtN.Clear();
                txtM.Clear();
                txtKetQua.Clear();
                txtN.Focus();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}

