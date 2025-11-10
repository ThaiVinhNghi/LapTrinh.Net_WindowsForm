namespace Buoi04_Bai_4._2
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btninmang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(458, 54);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(171, 26);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnTaomang
            // 
            this.btnTaomang.Location = new System.Drawing.Point(650, 37);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(136, 61);
            this.btnTaomang.TabIndex = 3;
            this.btnTaomang.Text = "Tao Mang Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(672, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 61);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btninmang
            // 
            this.btninmang.Location = new System.Drawing.Point(292, 326);
            this.btninmang.Name = "btninmang";
            this.btninmang.Size = new System.Drawing.Size(101, 61);
            this.btninmang.TabIndex = 5;
            this.btninmang.Text = "In Mang";
            this.btninmang.UseVisualStyleBackColor = true;
            this.btninmang.Click += new System.EventHandler(this.btnInmang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhap Mot Phan Tu";
            // 
            // lblKetqua
            // 
            this.lblKetqua.Location = new System.Drawing.Point(310, 116);
            this.lblKetqua.Multiline = true;
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(405, 148);
            this.lblKetqua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninmang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btninmang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblKetqua;
    }
}

