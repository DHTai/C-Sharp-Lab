
namespace Menu
{
    partial class Form_Menu
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
            this.btn_bai1 = new System.Windows.Forms.Button();
            this.btn_bai2 = new System.Windows.Forms.Button();
            this.btn_bai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_bai1
            // 
            this.btn_bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai1.Location = new System.Drawing.Point(84, 28);
            this.btn_bai1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bai1.Name = "btn_bai1";
            this.btn_bai1.Size = new System.Drawing.Size(266, 42);
            this.btn_bai1.TabIndex = 1;
            this.btn_bai1.Text = "Bài 1";
            this.btn_bai1.UseVisualStyleBackColor = true;
            this.btn_bai1.Click += new System.EventHandler(this.btn_bai1_Click);
            // 
            // btn_bai2
            // 
            this.btn_bai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai2.Location = new System.Drawing.Point(84, 86);
            this.btn_bai2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bai2.Name = "btn_bai2";
            this.btn_bai2.Size = new System.Drawing.Size(266, 42);
            this.btn_bai2.TabIndex = 1;
            this.btn_bai2.Text = "Bài 2";
            this.btn_bai2.UseVisualStyleBackColor = true;
            this.btn_bai2.Click += new System.EventHandler(this.btn_bai2_Click);
            // 
            // btn_bai3
            // 
            this.btn_bai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai3.Location = new System.Drawing.Point(84, 144);
            this.btn_bai3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bai3.Name = "btn_bai3";
            this.btn_bai3.Size = new System.Drawing.Size(266, 42);
            this.btn_bai3.TabIndex = 1;
            this.btn_bai3.Text = "Bài 3";
            this.btn_bai3.UseVisualStyleBackColor = true;
            this.btn_bai3.Click += new System.EventHandler(this.btn_bai3_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 205);
            this.Controls.Add(this.btn_bai3);
            this.Controls.Add(this.btn_bai2);
            this.Controls.Add(this.btn_bai1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_bai1;
        private System.Windows.Forms.Button btn_bai2;
        private System.Windows.Forms.Button btn_bai3;
    }
}

