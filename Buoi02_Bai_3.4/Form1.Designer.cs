namespace Buoi02_Bai_3._4
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label5 = new Label();
            txtKetQua = new TextBox();
            btnGiai = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 28);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "GIAI PHUONG TRINH BAC 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(264, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phuong Trinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 22);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhap a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 37);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhap b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 52);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "Nhap c:";
            // 
            // txtA
            // 
            txtA.Location = new Point(89, 14);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(90, 37);
            txtB.Name = "txtB";
            txtB.Size = new Size(99, 23);
            txtB.TabIndex = 4;
            // 
            // txtC
            // 
            txtC.Location = new Point(90, 66);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 26);
            txtC.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 178);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Ket qua:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(325, 176);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 23);
            txtKetQua.TabIndex = 3;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(301, 225);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(75, 23);
            btnGiai.TabIndex = 4;
            btnGiai.Text = "Giai";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGiai);
            Controls.Add(txtKetQua);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 3.4";
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
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Label label5;
        private TextBox txtKetQua;
        private Button btnGiai;
    }
}
