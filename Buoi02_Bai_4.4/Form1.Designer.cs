namespace Buoi02_Bai_4._4
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
            btnTinh = new Button();
            txtKetQua = new TextBox();
            label2 = new Label();
            txtN = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(347, 201);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 19;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(344, 153);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 23);
            txtKetQua.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 153);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 17;
            label2.Text = "S=";
            // 
            // txtN
            // 
            txtN.Location = new Point(345, 116);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 119);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 15;
            label1.Text = "n=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Controls.Add(label2);
            Controls.Add(txtN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cau truc lap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private TextBox txtKetQua;
        private Label label2;
        private TextBox txtN;
        private Label label1;
    }
}
