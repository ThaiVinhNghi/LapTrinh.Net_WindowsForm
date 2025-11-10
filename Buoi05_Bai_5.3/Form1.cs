using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_Bai_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int UCLN(int a, int b)
        {
            if (b == 0) return Math.Abs(a);
            return UCLN(b, a % b);
        }


        private void RutGon(ref int tu, ref int mau)
        {
            int uc = UCLN(tu, mau);
            tu /= uc;
            mau /= uc;
            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTu1.Text);
            int ms1 = int.Parse(txtMau1.Text);
            int ts2 = int.Parse(txtTu2.Text);
            int ms2 = int.Parse(txtMau2.Text);

            int tu = ts1 * ms2 + ts2 * ms1;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTu1.Text);
            int ms1 = int.Parse(txtMau1.Text);
            int ts2 = int.Parse(txtTu2.Text);
            int ms2 = int.Parse(txtMau2.Text);

            int tu = ts1 * ms2;
            int mau = ms1 * ts2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTu1.Text);
            int ms1 = int.Parse(txtMau1.Text);
            int ts2 = int.Parse(txtTu2.Text);
            int ms2 = int.Parse(txtMau2.Text);

            int tu = ts1 * ms2 - ts2 * ms1;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTu1.Text);
            int ms1 = int.Parse(txtMau1.Text);
            int ts2 = int.Parse(txtTu2.Text);
            int ms2 = int.Parse(txtMau2.Text);

            int tu = ts1 * ts2;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void txtTu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_2(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
