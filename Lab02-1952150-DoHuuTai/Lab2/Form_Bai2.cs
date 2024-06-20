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
    public partial class Form_Bai2 : Form
    {
        public Form_Bai2()
        {
            InitializeComponent();
        }

        private void btn_docfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string noidung = sr.ReadToEnd();

                txt_noidung.Text = noidung;
                txt_tenfile.Text = ofd.SafeFileName;
                txt_url.Text = path;
                txt_sodong.Text = txt_noidung.Lines.Count().ToString();
                txt_sokytu.Text = noidung.Length.ToString();

                noidung = noidung.Replace("\r\n", "\r");
                noidung = noidung.Replace("\r", " ");
                string[] words = noidung.Split(new char[] { '.', '?', '!', ';', ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                txt_sotu.Text = words.Count().ToString();
            }
        }
    }
}
