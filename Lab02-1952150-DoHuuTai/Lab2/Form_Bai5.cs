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
    public partial class Form_Bai5 : Form
    {
        public Form_Bai5()
        {
            InitializeComponent();
        }

        private void Form_Bai5_Load(object sender, EventArgs e)
        { 
            list_directory.View = View.Details;
            list_directory.GridLines = true;
            list_directory.FullRowSelect = true;
            list_directory.BackColor = SystemColors.Control;
            list_directory.HeaderStyle = ColumnHeaderStyle.Nonclickable;


            list_directory.Columns.Add("Tên file", 300, HorizontalAlignment.Left);
            list_directory.Columns.Add("Kích thước", 150, HorizontalAlignment.Left);
            list_directory.Columns.Add("Đuôi mở rộng", 150, HorizontalAlignment.Left);
            list_directory.Columns.Add("Ngày khởi tạo", -2, HorizontalAlignment.Left);
        }

        private void btn_chonthumuc_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                DirectoryInfo directory_info = new DirectoryInfo(path);
                FileInfo[] file_info = directory_info.GetFiles();

                txt_tenthumuc.Text = directory_info.Name;
                txt_duongdan.Text = directory_info.FullName;

                list_directory.Items.Clear();

                foreach (FileInfo fi in file_info)
                {
                    string[] info = new string[4];
                    info[0] = fi.Name;
                    info[1] = fi.Length.ToString();
                    info[2] = fi.Extension;
                    info[3] = fi.CreationTime.ToString();

                    ListViewItem lvi = new ListViewItem(info);
                    list_directory.Items.Add(lvi);
                }
             
            }
        }


    }
}
