namespace Buoi02_Bai_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();  
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Chào " + hoTen, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    

