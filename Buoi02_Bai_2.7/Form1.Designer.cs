namespace Buoi02_Bai_2._7
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
            btnTong = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 43);
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
            groupBox1.Location = new Point(253, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // txtB
            // 
            txtB.Location = new Point(75, 41);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 18);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(75, 14);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 18);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 41);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhap b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhap a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 193);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 2;
            label4.Text = "Ket qua:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(332, 190);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 23);
            txtKetQua.TabIndex = 3;
            txtKetQua.TextChanged += txtKetQua_TextChanged;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(315, 228);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 4;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTong);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 2.7";
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
        private Button btnTong;
    }
}
