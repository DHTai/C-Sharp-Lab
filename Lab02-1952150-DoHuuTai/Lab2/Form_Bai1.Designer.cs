
namespace Lab2
{
    partial class Form_Bai1
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
            this.btn_docfile = new System.Windows.Forms.Button();
            this.btn_ghifile = new System.Windows.Forms.Button();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_docfile
            // 
            this.btn_docfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docfile.Location = new System.Drawing.Point(28, 30);
            this.btn_docfile.Name = "btn_docfile";
            this.btn_docfile.Size = new System.Drawing.Size(99, 44);
            this.btn_docfile.TabIndex = 0;
            this.btn_docfile.Text = "Đọc file";
            this.btn_docfile.UseVisualStyleBackColor = true;
            this.btn_docfile.Click += new System.EventHandler(this.btn_docfile_Click);
            // 
            // btn_ghifile
            // 
            this.btn_ghifile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghifile.Location = new System.Drawing.Point(28, 94);
            this.btn_ghifile.Name = "btn_ghifile";
            this.btn_ghifile.Size = new System.Drawing.Size(99, 44);
            this.btn_ghifile.TabIndex = 0;
            this.btn_ghifile.Text = "Ghi file";
            this.btn_ghifile.UseVisualStyleBackColor = true;
            this.btn_ghifile.Click += new System.EventHandler(this.btn_ghifile_Click);
            // 
            // txt_noidung
            // 
            this.txt_noidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_noidung.Enabled = false;
            this.txt_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noidung.Location = new System.Drawing.Point(157, 12);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.ReadOnly = true;
            this.txt_noidung.Size = new System.Drawing.Size(403, 276);
            this.txt_noidung.TabIndex = 1;
            // 
            // Form_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 300);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.btn_ghifile);
            this.Controls.Add(this.btn_docfile);
            this.Name = "Form_Bai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.Form_Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_docfile;
        private System.Windows.Forms.Button btn_ghifile;
        private System.Windows.Forms.TextBox txt_noidung;
    }
}