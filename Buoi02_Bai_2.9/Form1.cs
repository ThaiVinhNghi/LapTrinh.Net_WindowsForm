namespace Buoi02_Bai_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double cv = (a + b) * 2;
            txtKetQua.Text = " " + cv;
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double dt = a * b;
            txtKetQua.Text = " " + dt;
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double dc = Math.Sqrt(a * a + b * b);
            txtKetQua.Text = " " + dc;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            Application.Exit();
        }
    }
}
