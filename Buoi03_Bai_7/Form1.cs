using System;
using System.Windows.Forms;

namespace Buoi03_Bai_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double kq = a + b;
            txtKetQua.Text = kq.ToString();
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double kq = a - b;
            txtKetQua.Text = kq.ToString();
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double kq = a * b;
            txtKetQua.Text = kq.ToString();
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            if (b != 0)
            {
                double kq = a / b;
                txtKetQua.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Khong the chia cho 0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
