namespace Buoi02_Bai_2._8
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
            label5 = new Label();
            txtKetQua = new TextBox();
            btnTong = new Button();
            btnHieu = new Button();
            btnTich = new Button();
            btnThuong = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "PHEP TOAN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(279, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin:";
            // 
            // txtB
            // 
            txtB.Location = new Point(90, 41);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 16);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(90, 17);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 16);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 42);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhap b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 18);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhap a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 199);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 2;
            label4.Text = "Ket qua:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 259);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 3;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(352, 199);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 16);
            txtKetQua.TabIndex = 4;
            txtKetQua.TextChanged += textBox1_TextChanged;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(280, 231);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(361, 231);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(75, 23);
            btnHieu.TabIndex = 6;
            btnHieu.Text = "Hieu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(442, 231);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(75, 23);
            btnTich.TabIndex = 7;
            btnTich.Text = "Tich";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(523, 231);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(75, 23);
            btnThuong.TabIndex = 8;
            btnThuong.Text = "Thuong";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThuong);
            Controls.Add(btnTich);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(txtKetQua);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 2.8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtB;
        private TextBox txtA;
        private Label label4;
        private Label label5;
        private TextBox txtKetQua;
        private Button btnTong;
        private Button btnHieu;
        private Button btnTich;
        private Button btnThuong;
    }
}
