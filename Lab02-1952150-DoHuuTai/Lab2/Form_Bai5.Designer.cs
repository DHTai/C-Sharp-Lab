
namespace Lab2
{
    partial class Form_Bai5
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
            this.list_directory = new System.Windows.Forms.ListView();
            this.btn_chonthumuc = new System.Windows.Forms.Button();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.txt_tenthumuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_directory
            // 
            this.list_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_directory.HideSelection = false;
            this.list_directory.Location = new System.Drawing.Point(-5, 106);
            this.list_directory.Name = "list_directory";
            this.list_directory.Size = new System.Drawing.Size(1022, 529);
            this.list_directory.TabIndex = 0;
            this.list_directory.UseCompatibleStateImageBehavior = false;
            // 
            // btn_chonthumuc
            // 
            this.btn_chonthumuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonthumuc.Location = new System.Drawing.Point(40, 19);
            this.btn_chonthumuc.Name = "btn_chonthumuc";
            this.btn_chonthumuc.Size = new System.Drawing.Size(203, 67);
            this.btn_chonthumuc.TabIndex = 1;
            this.btn_chonthumuc.Text = "Chọn thư mục";
            this.btn_chonthumuc.UseVisualStyleBackColor = true;
            this.btn_chonthumuc.Click += new System.EventHandler(this.btn_chonthumuc_Click);
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duongdan.Location = new System.Drawing.Point(431, 52);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.ReadOnly = true;
            this.txt_duongdan.Size = new System.Drawing.Size(425, 27);
            this.txt_duongdan.TabIndex = 2;
            // 
            // txt_tenthumuc
            // 
            this.txt_tenthumuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenthumuc.Location = new System.Drawing.Point(431, 19);
            this.txt_tenthumuc.Name = "txt_tenthumuc";
            this.txt_tenthumuc.ReadOnly = true;
            this.txt_tenthumuc.Size = new System.Drawing.Size(425, 27);
            this.txt_tenthumuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thư mục";
            // 
            // Form_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenthumuc);
            this.Controls.Add(this.txt_duongdan);
            this.Controls.Add(this.btn_chonthumuc);
            this.Controls.Add(this.list_directory);
            this.Name = "Form_Bai5";
            this.Text = "File explorer";
            this.Load += new System.EventHandler(this.Form_Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_directory;
        private System.Windows.Forms.Button btn_chonthumuc;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.TextBox txt_tenthumuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}