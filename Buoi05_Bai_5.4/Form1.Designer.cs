namespace Buoi05_Bai_5._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.rdoTron = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoVuong = new System.Windows.Forms.RadioButton();
            this.rdoTamGiac = new System.Windows.Forms.RadioButton();
            this.rdoChuNhat = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCanh = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCanhA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblCanhB = new System.Windows.Forms.Label();
            this.lblCanhC = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu Vi Và Diện Tích";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(111, 297);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(105, 59);
            this.btnThucHien.TabIndex = 1;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuNhat);
            this.groupBox1.Controls.Add(this.rdoTamGiac);
            this.groupBox1.Controls.Add(this.rdoVuong);
            this.groupBox1.Controls.Add(this.rdoTron);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(150, 39);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(100, 26);
            this.txtCanh1.TabIndex = 3;
            // 
            // rdoTron
            // 
            this.rdoTron.AutoSize = true;
            this.rdoTron.Location = new System.Drawing.Point(19, 34);
            this.rdoTron.Name = "rdoTron";
            this.rdoTron.Size = new System.Drawing.Size(123, 29);
            this.rdoTron.TabIndex = 4;
            this.rdoTron.TabStop = true;
            this.rdoTron.Text = "Hình Tròn";
            this.rdoTron.UseVisualStyleBackColor = true;
            this.rdoTron.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(258, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hình Tròn - Hình Vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(224, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình Tam Giac - Hình Chữ Nhật";
            // 
            // rdoVuong
            // 
            this.rdoVuong.AutoSize = true;
            this.rdoVuong.Location = new System.Drawing.Point(19, 90);
            this.rdoVuong.Name = "rdoVuong";
            this.rdoVuong.Size = new System.Drawing.Size(140, 29);
            this.rdoVuong.TabIndex = 5;
            this.rdoVuong.TabStop = true;
            this.rdoVuong.Text = "Hình Vuông";
            this.rdoVuong.UseVisualStyleBackColor = true;
            this.rdoVuong.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoTamGiac
            // 
            this.rdoTamGiac.AutoSize = true;
            this.rdoTamGiac.Location = new System.Drawing.Point(203, 34);
            this.rdoTamGiac.Name = "rdoTamGiac";
            this.rdoTamGiac.Size = new System.Drawing.Size(167, 29);
            this.rdoTamGiac.TabIndex = 6;
            this.rdoTamGiac.TabStop = true;
            this.rdoTamGiac.Text = "Hình Tam Giac";
            this.rdoTamGiac.UseVisualStyleBackColor = true;
            this.rdoTamGiac.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoChuNhat
            // 
            this.rdoChuNhat.AutoSize = true;
            this.rdoChuNhat.Location = new System.Drawing.Point(203, 90);
            this.rdoChuNhat.Name = "rdoChuNhat";
            this.rdoChuNhat.Size = new System.Drawing.Size(165, 29);
            this.rdoChuNhat.TabIndex = 7;
            this.rdoChuNhat.TabStop = true;
            this.rdoChuNhat.Text = "Hình Chữ Nhật";
            this.rdoChuNhat.UseVisualStyleBackColor = true;
            this.rdoChuNhat.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 59);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(507, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 59);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDienTich);
            this.groupBox3.Controls.Add(this.txtChuVi);
            this.groupBox3.Controls.Add(this.lblDienTich);
            this.groupBox3.Controls.Add(this.lblChuVi);
            this.groupBox3.Controls.Add(this.lblCanh);
            this.groupBox3.Controls.Add(this.txtCanh1);
            this.groupBox3.Location = new System.Drawing.Point(174, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 134);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblCanh
            // 
            this.lblCanh.AutoSize = true;
            this.lblCanh.Location = new System.Drawing.Point(28, 39);
            this.lblCanh.Name = "lblCanh";
            this.lblCanh.Size = new System.Drawing.Size(108, 20);
            this.lblCanh.TabIndex = 11;
            this.lblCanh.Text = "Nhập Cạnh A ";
            this.lblCanh.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(28, 74);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChuVi.Size = new System.Drawing.Size(60, 20);
            this.lblChuVi.TabIndex = 12;
            this.lblChuVi.Text = "Chu Vi ";
            this.lblChuVi.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(28, 111);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(79, 20);
            this.lblDienTich.TabIndex = 13;
            this.lblDienTich.Text = "Diện Tích ";
            this.lblDienTich.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(150, 74);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(100, 26);
            this.txtChuVi.TabIndex = 14;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(150, 106);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(100, 26);
            this.txtDienTich.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.lblCanhC);
            this.groupBox2.Controls.Add(this.lblCanhB);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.lblCanhA);
            this.groupBox2.Location = new System.Drawing.Point(426, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 125);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập cạnh";
            // 
            // lblCanhA
            // 
            this.lblCanhA.AutoSize = true;
            this.lblCanhA.Location = new System.Drawing.Point(26, 24);
            this.lblCanhA.Name = "lblCanhA";
            this.lblCanhA.Size = new System.Drawing.Size(99, 20);
            this.lblCanhA.TabIndex = 0;
            this.lblCanhA.Text = "Nhập cạnh a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(168, 21);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 1;
            // 
            // lblCanhB
            // 
            this.lblCanhB.AutoSize = true;
            this.lblCanhB.Location = new System.Drawing.Point(26, 59);
            this.lblCanhB.Name = "lblCanhB";
            this.lblCanhB.Size = new System.Drawing.Size(99, 20);
            this.lblCanhB.TabIndex = 2;
            this.lblCanhB.Text = "Nhập cạnh b";
            // 
            // lblCanhC
            // 
            this.lblCanhC.AutoSize = true;
            this.lblCanhC.Location = new System.Drawing.Point(26, 99);
            this.lblCanhC.Name = "lblCanhC";
            this.lblCanhC.Size = new System.Drawing.Size(98, 20);
            this.lblCanhC.TabIndex = 3;
            this.lblCanhC.Text = "Nhập cạnh c";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(168, 56);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(168, 99);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tìm Chu Vi Và Diện Tích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.RadioButton rdoTron;
        private System.Windows.Forms.RadioButton rdoChuNhat;
        private System.Windows.Forms.RadioButton rdoTamGiac;
        private System.Windows.Forms.RadioButton rdoVuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCanh;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCanhC;
        private System.Windows.Forms.Label lblCanhB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblCanhA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
    }
}

