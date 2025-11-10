namespace Buoi02_Bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtX_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 double x,y;
              if (!double.TryParse(txtX.Text, out x))
                {
                    MessageBox.Show("Vui lòng nhập số thực hợp lệ!", "Lỗi nhập liệu");
                    return;
                }

                if (x >= 2)
                    y = -8 * Math.Pow(x, 3) - 12 * x - 1;
                else if (x > 1 && x < 2)
                    y = Math.Pow(x, 2) - 6 * x - 19;
                else
                    y = 7 * x;
                txtKetQua.Text = y.ToString();
            }
        }

    }
}
   