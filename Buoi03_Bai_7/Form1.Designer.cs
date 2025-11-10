namespace Buoi03_Bai_7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tinhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Location = new System.Drawing.Point(263, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thong tin";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(82, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(82, 61);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(330, 248);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 20);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "phep toan don gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "nhap a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "nhap b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ket qua";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhToanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tinhToanToolStripMenuItem
            // 
            this.tinhToanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tongToolStripMenuItem,
            this.hieuToolStripMenuItem,
            this.tichToolStripMenuItem,
            this.thuongToolStripMenuItem});
            this.tinhToanToolStripMenuItem.Name = "tinhToanToolStripMenuItem";
            this.tinhToanToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tinhToanToolStripMenuItem.Text = "Tinh toan";
            // 
            // tongToolStripMenuItem
            // 
            this.tongToolStripMenuItem.Name = "tongToolStripMenuItem";
            this.tongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tongToolStripMenuItem.Text = "Tong ";
            // 
            // hieuToolStripMenuItem
            // 
            this.hieuToolStripMenuItem.Name = "hieuToolStripMenuItem";
            this.hieuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hieuToolStripMenuItem.Text = "Hieu";
            // 
            // tichToolStripMenuItem
            // 
            this.tichToolStripMenuItem.Name = "tichToolStripMenuItem";
            this.tichToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tichToolStripMenuItem.Text = "Tich";
            // 
            // thuongToolStripMenuItem
            // 
            this.thuongToolStripMenuItem.Name = "thuongToolStripMenuItem";
            this.thuongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thuongToolStripMenuItem.Text = "Thuong";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tinhToanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuongToolStripMenuItem;
    }
}

