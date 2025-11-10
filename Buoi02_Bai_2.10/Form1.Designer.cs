namespace Buoi02_Bai_2._10
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
            btnThoat = new Button();
            btnDuongCheo = new Button();
            btnDienTich = new Button();
            btnChuVi = new Button();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(492, 234);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Location = new Point(401, 234);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(85, 23);
            btnDuongCheo.TabIndex = 14;
            btnDuongCheo.Text = "Duong cheo";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(320, 234);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(75, 23);
            btnDienTich.TabIndex = 13;
            btnDienTich.Text = "Dien Tich";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(239, 234);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(75, 23);
            btnChuVi.TabIndex = 12;
            btnChuVi.Text = "Chu Vi";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(226, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 52);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "HINH CHU NHAT";
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
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 2.10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnDuongCheo;
        private Button btnDienTich;
        private Button btnChuVi;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
