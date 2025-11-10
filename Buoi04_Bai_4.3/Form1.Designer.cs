namespace Buoi04_Bai_4._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.ListBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhap Mot Phan Tu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblketqua
            // 
            this.lblketqua.FormattingEnabled = true;
            this.lblketqua.ItemHeight = 20;
            this.lblketqua.Location = new System.Drawing.Point(92, 208);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(467, 84);
            this.lblketqua.TabIndex = 1;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(272, 90);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 26);
            this.txtNhap.TabIndex = 2;
            // 
            // btnTaomang
            // 
            this.btnTaomang.Location = new System.Drawing.Point(378, 83);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(222, 40);
            this.btnTaomang.TabIndex = 3;
            this.btnTaomang.Text = "Tao Mang Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(72, 335);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(128, 40);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Tong Mang";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(254, 335);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(128, 40);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "So Lon Nhat";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(416, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lblketqua;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnThoat;
    }
}

