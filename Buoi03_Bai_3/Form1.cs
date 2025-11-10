using System;
using System.Windows.Forms;

namespace Buoi03_Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKetQua.Text = "Bạn đã chọn website ";
            this.txtKetQua.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKetQua.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi trẻ");
            this.lstWeb.Items.Add("Thanh niên");
            this.lstWeb.Items.Add("VNExpress");
            this.lstWeb.Items.Add("Dân trí");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.SelectedItem = "Tuổi trẻ";
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.txtKetQua.Text = "Bạn đã chọn website ";
            this.txtKetQua.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            this.txtKetQua.ClearSelected();
        }
    }
}
