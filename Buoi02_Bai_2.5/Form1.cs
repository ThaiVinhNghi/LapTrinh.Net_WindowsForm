namespace Buoi02_Bai_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double tong = a + b;
            MessageBox.Show("Tổng hai số là: " + tong);
        }
    }
}
