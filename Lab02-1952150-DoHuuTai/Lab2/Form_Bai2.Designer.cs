
namespace Lab2
{
    partial class Form_Bai2
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
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.txt_tenfile = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_sodong = new System.Windows.Forms.TextBox();
            this.txt_sotu = new System.Windows.Forms.TextBox();
            this.txt_sokytu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_docfile
            // 
            this.btn_docfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docfile.Location = new System.Drawing.Point(83, 12);
            this.btn_docfile.Name = "btn_docfile";
            this.btn_docfile.Size = new System.Drawing.Size(181, 61);
            this.btn_docfile.TabIndex = 0;
            this.btn_docfile.Text = "Đọc file";
            this.btn_docfile.UseVisualStyleBackColor = true;
            this.btn_docfile.Click += new System.EventHandler(this.btn_docfile_Click);
            // 
            // txt_noidung
            // 
            this.txt_noidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_noidung.Enabled = false;
            this.txt_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noidung.Location = new System.Drawing.Point(365, 12);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.ReadOnly = true;
            this.txt_noidung.Size = new System.Drawing.Size(431, 316);
            this.txt_noidung.TabIndex = 1;
            // 
            // txt_tenfile
            // 
            this.txt_tenfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenfile.Location = new System.Drawing.Point(114, 108);
            this.txt_tenfile.Name = "txt_tenfile";
            this.txt_tenfile.ReadOnly = true;
            this.txt_tenfile.Size = new System.Drawing.Size(207, 27);
            this.txt_tenfile.TabIndex = 2;
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(114, 151);
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.Size = new System.Drawing.Size(207, 27);
            this.txt_url.TabIndex = 2;
            // 
            // txt_sodong
            // 
            this.txt_sodong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodong.Location = new System.Drawing.Point(114, 194);
            this.txt_sodong.Name = "txt_sodong";
            this.txt_sodong.ReadOnly = true;
            this.txt_sodong.Size = new System.Drawing.Size(207, 27);
            this.txt_sodong.TabIndex = 2;
            // 
            // txt_sotu
            // 
            this.txt_sotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotu.Location = new System.Drawing.Point(114, 237);
            this.txt_sotu.Name = "txt_sotu";
            this.txt_sotu.ReadOnly = true;
            this.txt_sotu.Size = new System.Drawing.Size(207, 27);
            this.txt_sotu.TabIndex = 2;
            // 
            // txt_sokytu
            // 
            this.txt_sokytu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sokytu.Location = new System.Drawing.Point(114, 280);
            this.txt_sokytu.Name = "txt_sokytu";
            this.txt_sokytu.ReadOnly = true;
            this.txt_sokytu.Size = new System.Drawing.Size(207, 27);
            this.txt_sokytu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số ký tự";
            // 
            // Form_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 340);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sokytu);
            this.Controls.Add(this.txt_sotu);
            this.Controls.Add(this.txt_sodong);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_tenfile);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.btn_docfile);
            this.Name = "Form_Bai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_docfile;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.TextBox txt_tenfile;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_sodong;
        private System.Windows.Forms.TextBox txt_sotu;
        private System.Windows.Forms.TextBox txt_sokytu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}