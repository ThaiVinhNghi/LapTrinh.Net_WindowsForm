namespace Buoi02_Bai_3._1
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
            txtX = new TextBox();
            label3 = new Label();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 43);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "TINH GIA TRI HAM SO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 82);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhap x=";
            // 
            // txtX
            // 
            txtX.Location = new Point(288, 79);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 2;
            txtX.KeyDown += txtX_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 124);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Ket qua f=";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(297, 121);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(100, 23);
            txtKetQua.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(txtX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 3.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtX;
        private Label label3;
        private TextBox txtKetQua;
    }
}
