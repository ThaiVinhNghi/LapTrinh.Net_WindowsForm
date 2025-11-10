namespace Buoi03_Bai_8
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
            this.cboHoTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienLoIChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboHoTen
            // 
            this.cboHoTen.FormattingEnabled = true;
            this.cboHoTen.Location = new System.Drawing.Point(326, 83);
            this.cboHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHoTen.Name = "cboHoTen";
            this.cboHoTen.Size = new System.Drawing.Size(180, 28);
            this.cboHoTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ho ten";
            // 
            // btnHienLoIChao
            // 
            this.btnHienLoIChao.Location = new System.Drawing.Point(302, 325);
            this.btnHienLoIChao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienLoIChao.Name = "btnHienLoIChao";
            this.btnHienLoIChao.Size = new System.Drawing.Size(112, 35);
            this.btnHienLoIChao.TabIndex = 2;
            this.btnHienLoIChao.Text = "hien loi chao";
            this.btnHienLoIChao.UseVisualStyleBackColor = true;
            this.btnHienLoIChao.Click += new System.EventHandler(this.btnHienLoIChao_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnHienLoIChao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHoTen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienLoIChao;
    }
}

