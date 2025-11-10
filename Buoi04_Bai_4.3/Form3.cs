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
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a)
        {
            InitializeComponent();
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            int max = c.Max();
            lblKQ.Text = "Số lớn nhất trong mảng là: " + max;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
