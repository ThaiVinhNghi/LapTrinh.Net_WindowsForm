namespace Buoi02_Bai_3._2
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
            label2 = new Label();
            btnThongBao = new Button();
            txtNhap = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "MUA TRONG NAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 78);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Thang:";
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(262, 117);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(75, 23);
            btnThongBao.TabIndex = 2;
            btnThongBao.Text = "Thong Bao";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(256, 75);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(100, 23);
            txtNhap.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNhap);
            Controls.Add(btnThongBao);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 3.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnThongBao;
        private TextBox txtNhap;
    }
}
