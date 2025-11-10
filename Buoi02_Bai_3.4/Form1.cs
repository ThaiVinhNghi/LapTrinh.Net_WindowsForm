namespace Buoi02_Bai_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;

            // Kiểm tra dữ liệu nhập
            if (!double.TryParse(txtA.Text, out a) ||
                !double.TryParse(txtB.Text, out b) ||
                !double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho a, b, c!", "Lỗi nhập liệu");
                return;
            }

            // Trường hợp a = 0 → phương trình bậc 1
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        txtKetQua.Text = "Phương trình vô số nghiệm.";
                    else
                        txtKetQua.Text = "Phương trình vô nghiệm.";
                }
                else
                {
                    x1 = -c / b;
                    txtKetQua.Text = "Phương trình có 1 nghiệm: x = " + x1.ToString();
                }
            }
            else
            {
                // Tính delta
                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtKetQua.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    txtKetQua.Text = "Phương trình có nghiệm kép: x = " + x1.ToString();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKetQua.Text = "x1 = " + x1.ToString() + " ; x2 = " + x2.ToString();
                }
            }
        }
    }
}

