
namespace buoi07_bai_7._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnMoDanhSach;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnMoDanhSach = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTruoc.Location = new System.Drawing.Point(43, 381);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(86, 35);
            this.btnTruoc.TabIndex = 1;
            this.btnTruoc.Text = "<< Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnMoDanhSach
            // 
            this.btnMoDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMoDanhSach.Location = new System.Drawing.Point(171, 381);
            this.btnMoDanhSach.Name = "btnMoDanhSach";
            this.btnMoDanhSach.Size = new System.Drawing.Size(129, 35);
            this.btnMoDanhSach.TabIndex = 2;
            this.btnMoDanhSach.Text = "Mở danh sách hình";
            this.btnMoDanhSach.UseVisualStyleBackColor = true;
            this.btnMoDanhSach.Click += new System.EventHandler(this.btnMoDanhSach_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSau.Location = new System.Drawing.Point(343, 381);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(86, 35);
            this.btnSau.TabIndex = 3;
            this.btnSau.Text = "Sau >>";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatDau.Location = new System.Drawing.Point(471, 381);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(86, 35);
            this.btnBatDau.TabIndex = 4;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.Location = new System.Drawing.Point(583, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 434);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnMoDanhSach);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình xem ảnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
