using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTaiKhoanApp.DAO;

namespace QLTaiKhoanApp
{
    public partial class PhieuRutTien : Form
    {
        public PhieuRutTien()
        {
            InitializeComponent();
        }

        private void PhieuRutTien_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void PhieuRutTien_Load(object sender, EventArgs e)
        {
            loadMaPhieu();
            loadmaGDV();
        }

        public  void loadMaPhieu()
        {
            for (int i = 0; i < getmaPhieu().Rows.Count; i++)
            {
                maPhieu_PRT_cbb.Items.Add(getmaPhieu().Rows[i]["MAPHIEU"]);
            }
        }

        public DataTable getmaPhieu()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEU");
            return data;
        }

        private void maPhieu_PRT_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTTKH();
            getTTPhieu();
        }

        public void getTTPhieu()
        {
            string maPhieu = maPhieu_PRT_cbb.SelectedItem.ToString();
            maDV_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["MADV"].ToString();
            DV_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["TENDV"].ToString();
            kyHan_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["KYHAN"].ToString();
            ngayGui_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["NGAYGUI"].ToString();
            ngayDenHan_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["NGAYDENHAN"].ToString();
            laiSuat_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["LAISUAT"].ToString();
            soTienGui_PRT_tb.Text = loadTTPhieu(maPhieu).Rows[0]["SOTIEN_GUI"].ToString();

        }

        public DataTable getmaGDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAODICHVIEN ");
            return data;
        }

        public void loadmaGDV()
        {
            for (int i = 0; i < getmaGDV().Rows.Count; i++)
            {
                maGDV_PRT_cbb.Items.Add(getmaGDV().Rows[i]["MAGDV"]);
            }
        }

        public DataTable loadTTPhieu(string maPhieu)
        {
            string query = String.Format("SELECT * FROM PHIEU a, DICHVU b WHERE a.MADV=b.MADV AND a.MAPHIEU = '" + maPhieu + "'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable loadTTKH(string maPhieu)
        {

            string query = String.Format("SELECT * FROM PHIEU a, KHACHHANG b WHERE a.CMND=b.CMND AND a.MAPHIEU = '" + maPhieu + "'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return data;
        }

        public void getTTKH()
        {
            string maPhieu = maPhieu_PRT_cbb.SelectedItem.ToString();
            ten_PRT_tb.Text = loadTTKH(maPhieu).Rows[0]["HOTEN"].ToString();
            diachi_PRT_tb.Text = loadTTKH(maPhieu).Rows[0]["DIACHI"].ToString();
            cmnd_PRT_tb.Text = loadTTKH(maPhieu).Rows[0]["CMND"].ToString();
            ngayCap_PRT_tb.Text = loadTTKH(maPhieu).Rows[0]["NGAYCAP"].ToString();
        }

        private void tinhtienlai_PRT_btn_Click(object sender, EventArgs e)
        {
            DateTime ngayrut = Convert.ToDateTime(dateTimePicker_PRT_ngayrut.Value);
            DateTime ngaydenhan = Convert.ToDateTime(DateTime.Parse(ngayDenHan_PRT_tb.Text));
            DateTime ngaygui = Convert.ToDateTime(DateTime.Parse(ngayGui_PRT_tb.Text));
            float laisuat = float.Parse(laiSuat_PRT_tb.Text);
            float tienlai = 0;
            float tongtien = 0;
            float sotiengui = float.Parse(soTienGui_PRT_tb.Text);
            
            float kyhan = float.Parse(kyHan_PRT_tb.Text);

            Console.WriteLine("lai suat : " + laisuat);
            Console.WriteLine("ngay den han"+ngaydenhan);
            Console.WriteLine("ngay gui "+ngaygui);
            Console.WriteLine("so tien gui " + sotiengui);
            Console.WriteLine("ky han " + kyhan);

            TimeSpan temp = (ngayrut - ngaydenhan);
            float temps = temp.Days;
            if (ngayrut < ngaydenhan)
            {
                TimeSpan tongngay = (ngayrut - ngaygui);
                float tongsongay = tongngay.Days;
                tienlai = sotiengui * (tongsongay / 30) * (laisuat/100);
                tongtien = sotiengui + tienlai;
                tongSoTienRut_PRT_tb.Text = tongtien.ToString();
                tienLai_PRT_tb.Text = tienlai.ToString();
            }
            else if(temps==0)
            {
                tienlai = sotiengui * kyhan * (laisuat/100);
                tongtien = sotiengui + tienlai;
                tongSoTienRut_PRT_tb.Text = tongtien.ToString();
                tienLai_PRT_tb.Text = tienlai.ToString();

            }
            else if(ngayrut > ngaydenhan)
            {
                TimeSpan tongngay = (ngayrut - ngaydenhan);
                float tongsongay = tongngay.Days;
                tienlai = (sotiengui * kyhan * (laisuat/100) + sotiengui) * (tongsongay / 30) * (laisuat/100);
                tongtien = (sotiengui * kyhan * (laisuat / 100) + sotiengui) + tienlai;
                float laithuc = tienlai + sotiengui * kyhan * (laisuat / 100);
                tongSoTienRut_PRT_tb.Text = tongtien.ToString();
                tienLai_PRT_tb.Text = laithuc.ToString();

            }
            else
            {
                Console.WriteLine("fail ");
            }
            

            
        }

        private void ghi_PRT_btn_Click(object sender, EventArgs e)
        {
            string ngayrut = dateTimePicker_PRT_ngayrut.Value.ToString("d");
            int tienlai = Int32.Parse(tienLai_PRT_tb.Text);
            string maGDV = maGDV_PRT_cbb.Text;
            string maPhieu = maPhieu_PRT_cbb.Text;
            if(updatePhieu(ngayrut, tienlai, maGDV, maPhieu))
            {
                MessageBox.Show("Rút Tiền Thành Công");
            }
            else
            {
                MessageBox.Show("Rút Tiền Thất Bại");
            }
        }

        bool updatePhieu(string ngayrut, int tienlai, string maGDV, string maPhieu)
        {
            string query = string.Format("UPDATE PHIEU SET NGAYRUT ='{0}', TIENLAI = '{1}', MAGDV_LPR = '{2}' WHERE MAPHIEU = '{3}'", ngayrut, tienlai, maGDV, maPhieu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        private void thoat_PRT_btn_Click(object sender, EventArgs e)
        {
            MainFormAdmin lgf = new MainFormAdmin();
            this.Hide();
            lgf.Show();
        }
    }
}
