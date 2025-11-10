namespace Buoi02_Bai_2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double cv = (a + b) * 2;
            MessageBox.Show("Chu vi hinh chu nhat la: " + cv);
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double dt = a * b;
            MessageBox.Show("Dien tich hinh chu nhat la: " + dt);
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double dc = Math.Sqrt(a * a + b * b);
            MessageBox.Show("Do dai duong cheo hinh chu nhat la: " + dc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            Application.Exit();
        }
    }
}
