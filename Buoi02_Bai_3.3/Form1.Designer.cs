namespace Buoi02_Bai_3._3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKiemTra = new Button();
            txtNgay = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 39);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "KIEM TRA NGAY HOP LE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(txtThang);
            groupBox1.Controls.Add(txtNgay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(255, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Ngay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 42);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Thang:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 69);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Nam:";
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(311, 182);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(75, 23);
            btnKiemTra.TabIndex = 2;
            btnKiemTra.Text = "Kiem tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(73, 16);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(100, 23);
            txtNgay.TabIndex = 3;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(73, 42);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(100, 23);
            txtThang.TabIndex = 4;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(73, 66);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(100, 23);
            txtNam.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKiemTra);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 3.3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnKiemTra;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtNgay;
    }
}
