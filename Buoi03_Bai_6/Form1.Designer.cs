namespace Buoi03_Bai_6
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
            this.lstTen = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMauNen = new System.Windows.Forms.Button();
            this.btnChonFont = new System.Windows.Forms.Button();
            this.btnChonMauChu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTen
            // 
            this.lstTen.FormattingEnabled = true;
            this.lstTen.Items.AddRange(new object[] {
            "Ta Nguyen Thanh Tin",
            "Tran Quang Toan",
            "Nguyen Hoang Uy",
            "Thai Vinh Nghi",
            "Vo Hoang Quan",
            "Nguyen Van Chi Hao",
            "Nguyen Ngoc Tai"});
            this.lstTen.Location = new System.Drawing.Point(98, 230);
            this.lstTen.Name = "lstTen";
            this.lstTen.Size = new System.Drawing.Size(120, 95);
            this.lstTen.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(84, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "them ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnMauNen
            // 
            this.btnMauNen.Location = new System.Drawing.Point(451, 181);
            this.btnMauNen.Name = "btnMauNen";
            this.btnMauNen.Size = new System.Drawing.Size(113, 23);
            this.btnMauNen.TabIndex = 2;
            this.btnMauNen.Text = "chon mau nen";
            this.btnMauNen.UseVisualStyleBackColor = true;
            // 
            // btnChonFont
            // 
            this.btnChonFont.Location = new System.Drawing.Point(570, 181);
            this.btnChonFont.Name = "btnChonFont";
            this.btnChonFont.Size = new System.Drawing.Size(95, 23);
            this.btnChonFont.TabIndex = 3;
            this.btnChonFont.Text = "chon font";
            this.btnChonFont.UseVisualStyleBackColor = true;
            // 
            // btnChonMauChu
            // 
            this.btnChonMauChu.Location = new System.Drawing.Point(340, 181);
            this.btnChonMauChu.Name = "btnChonMauChu";
            this.btnChonMauChu.Size = new System.Drawing.Size(105, 23);
            this.btnChonMauChu.TabIndex = 4;
            this.btnChonMauChu.Text = "chon mau chu";
            this.btnChonMauChu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(442, 230);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(185, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(60, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhap chuoi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(38, 41);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(130, 20);
            this.txtNhap.TabIndex = 8;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(403, 88);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(197, 20);
            this.txtKetQua.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChonMauChu);
            this.Controls.Add(this.btnChonFont);
            this.Controls.Add(this.btnMauNen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lstTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnMauNen;
        private System.Windows.Forms.Button btnChonFont;
        private System.Windows.Forms.Button btnChonMauChu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

