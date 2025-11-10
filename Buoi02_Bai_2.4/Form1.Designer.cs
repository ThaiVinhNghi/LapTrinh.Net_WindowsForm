namespace Buoi02_Bai_2._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoTen = new Label();
            HoTen = new TextBox();
            btnHienThi = new Button();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.AutoSize = true;
            txtHoTen.Location = new Point(209, 108);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(46, 15);
            txtHoTen.TabIndex = 0;
            txtHoTen.Text = "Ho ten:";
            // 
            // HoTen
            // 
            HoTen.Location = new Point(261, 105);
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(100, 23);
            HoTen.TabIndex = 1;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(245, 134);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hien thi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHienThi);
            Controls.Add(HoTen);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Bai 2.4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHoTen;
        private TextBox HoTen;
        private Button btnHienThi;
    }
}
