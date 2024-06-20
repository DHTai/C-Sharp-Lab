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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    public partial class Form_Bai4 : Form
    {
        [Serializable]
        public class SINHVIEN
        {
            public string MSSV = "";
            public string HoTen = "";
            public string SDT = "";
            public float DiemToan = 0;
            public float DiemVan = 0;
            [NonSerialized]
            public float DiemTB = 0;
        }

        private List<SINHVIEN> ds_sinhvien = new List<SINHVIEN>();

        public Form_Bai4()
        {
            InitializeComponent();
        }

        private void btn_themsv_Click(object sender, EventArgs e)
        {
            if (kiem_tra_dulieu_nhap())
            {
                SINHVIEN sinhvien = new SINHVIEN
                {
                    MSSV = txt_mssv.Text,
                    HoTen = txt_hoten.Text,
                    SDT = txt_sdt.Text,
                    DiemToan = float.Parse(txt_diemtoan.Text),
                    DiemVan = float.Parse(txt_diemvan.Text)
                };

                // Thêm thông tin sinh viên vào list danh sách sinh viên
                ds_sinhvien.Add(sinhvien);

                // Hiện thị cho người dùng xem
                hien_thi_preview(ds_sinhvien.Count, txt_mssv.Text, txt_hoten.Text, txt_sdt.Text, float.Parse(txt_diemtoan.Text), float.Parse(txt_diemvan.Text));
                
                // Reset các thông tin
                txt_mssv.Text = "";
                txt_hoten.Text = "";
                txt_sdt.Text = "";
                txt_diemtoan.Text = "";
                txt_diemvan.Text = "";
            }
        }

        private void btn_luufile_Click(object sender, EventArgs e)
        {
            if (ds_sinhvien.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên rỗng", "Lỗi dữ liệu");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text file (*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    FileStream fs = new FileStream(path, FileMode.Create);

                    try
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fs, ds_sinhvien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                        throw;
                    }
                    finally
                    {
                        fs.Close();
                        ds_sinhvien.Clear();
                        MessageBox.Show("Ghi file thành công", "Xong");
                    }

                    // Xóa hiện thị ở ô preview
                    rich_preview.Text = "";

                }
            }
        }

        private void btn_tinhdiem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

                ds_sinhvien = null;

                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    ds_sinhvien = (List<SINHVIEN>) binaryFormatter.Deserialize(fs);

                    int i = 1;
                    foreach (SINHVIEN sv in ds_sinhvien)
                    {
                        sv.DiemTB = (sv.DiemToan + sv.DiemVan) / 2;
                        hien_thi_preview(i, sv.MSSV, sv.HoTen, sv.SDT, sv.DiemToan, sv.DiemVan, sv.DiemTB);
                        i++;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                    throw;
                }
                finally
                {
                    string path_save = Path.GetDirectoryName(path) + "\\ouput.txt";
                    fs = new FileStream(path_save, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);

                    try
                    {
                        sw.WriteAsync(rich_preview.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    finally
                    {
                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("Lưu file kết quả thành công\r\n" + path_save, "Xong");
                    }

                    fs.Close();
                }
            }
        }

        private bool kiem_tra_dulieu_nhap()
        {
            if (txt_mssv.Text == "" || txt_mssv.Text.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập đúng MSSV", "Lỗi dữ liệu");
                return false;
            }
            if (txt_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đúng họ và tên", "Lỗi dữ liệu");
                return false;
            }
            if (txt_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đúng SĐT", "Lỗi dữ liệu");
                return false;
            }
            if (txt_diemtoan.Text == "" || (float.Parse(txt_diemtoan.Text) < 0 || float.Parse(txt_diemtoan.Text) > 10))
            {
                MessageBox.Show("Vui lòng nhập đúng điểm toán", "Lỗi dữ liệu");
                return false;
            }
            if (txt_diemvan.Text == "" || (float.Parse(txt_diemvan.Text) < 0 || float.Parse(txt_diemvan.Text) > 10))
            {
                MessageBox.Show("Vui lòng nhập đúng điểm văn", "Lỗi dữ liệu");
                return false;
            }
            return true;
        }
        
        private void hien_thi_preview(int stt, string mssv, string hoten, string sdt, float diemtoan, float diemvan, float diemtb = -1)
        {
            rich_preview.Text += "STT: " + stt.ToString();
            rich_preview.Text += "\r\nMSSV: " + mssv;
            rich_preview.Text += "\r\nHo va ten: " + hoten;
            rich_preview.Text += "\r\nSDT: " + sdt;
            rich_preview.Text += "\r\nToan: " + diemtoan.ToString();
            rich_preview.Text += "\r\nVan: " + diemvan.ToString();
            if (diemtb != -1)
            {
                rich_preview.Text += "\r\nDiem TB: " + diemtb.ToString();
            }
            rich_preview.Text += "\r\n\r\n";
        }
    }
}
