using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Form_Bai1 form_bai1 = new Form_Bai1();
            form_bai1.StartPosition = FormStartPosition.CenterScreen;
            form_bai1.Show();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Form_Bai2 form_bai2 = new Form_Bai2();
            form_bai2.StartPosition = FormStartPosition.CenterScreen;
            form_bai2.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Form_Bai3 form_bai3 = new Form_Bai3();
            form_bai3.StartPosition = FormStartPosition.CenterScreen;
            form_bai3.Show();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Form_Bai4 form_bai4 = new Form_Bai4();
            form_bai4.Show();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Form_Bai5 form_bai5 = new Form_Bai5();
            form_bai5.StartPosition = FormStartPosition.CenterScreen;
            form_bai5.Show();
        }

    }
}
