using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form_Bai1 : Form
    {
        public Form_Bai1()
        {
            InitializeComponent();
        }

        private void Form_Bai1_Load(object sender, EventArgs e)
        {
            btn_ghifile.Enabled = false;
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                txt_noidung.Text = content;
                if (txt_noidung.Text != "")
                {
                    btn_ghifile.Enabled = true;
                }
                sr.Close();
                fs.Close();
            }
        }

        private void btn_ghifile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt) | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteAsync(txt_noidung.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Ghi file thành công", "Hoàn thành");
            }
        }
    }
}
