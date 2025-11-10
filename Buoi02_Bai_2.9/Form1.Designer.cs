namespace Buoi02_Bai_2._9
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtKetQua = new TextBox();
            btnChuVi = new Button();
            btnDienTich = new Button();
            btnDuongCheo = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "HINH CHU NHAT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(257, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin:";
            // 
            // txtB
            // 
            txtB.Location = new Point(82, 39);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 18);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(82, 21);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 18);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 39);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhap b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhap a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 201);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 2;
            label4.Text = "Ket qua:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(339, 195);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 23);
            txtKetQua.TabIndex = 3;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(270, 240);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(75, 23);
            btnChuVi.TabIndex = 4;
            btnChuVi.Text = "Chu Vi";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(351, 240);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(75, 23);
            btnDienTich.TabIndex = 5;
            btnDienTich.Text = "Dien Tich";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Location = new Point(432, 240);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(85, 23);
            btnDuongCheo.TabIndex = 6;
            btnDuongCheo.Text = "Duong cheo";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(523, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDuongCheo);
            Controls.Add(btnDienTich);
            Controls.Add(btnChuVi);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 2.9";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtKetQua;
        private Button btnChuVi;
        private Button btnDienTich;
        private Button btnDuongCheo;
        private Button btnThoat;
    }
}
