using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTaiKhoanApp.DAO;

namespace QLTaiKhoanApp
{
    public partial class PhieuGuiTien : Form
    {
        public PhieuGuiTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void thoat_PGT_btn_Click(object sender, EventArgs e)
        {
            MainFormAdmin lgf = new MainFormAdmin();
            this.Hide();
            lgf.Show();
        }

        private void PhieuGuiTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ghi_PGT_btn_Click(object sender, EventArgs e)
        {
            string maPhieu = maPhieu_PGT_tb.Text;
            string ngayGui = dateTimePicker_ngayGui_PGT.Value.ToString("d");
            string maKH = maKH_PGT_tb.Text;
            string maGDV_LPG = maGDV_PGT_cbb.Text;
            string tenKH = tenKH_PGT_tb.Text;
            string diachi = diachi_PGT_tb.Text;

            string cmnd = cmnd_PGT_tb.Text;

            
            string maDV = comboBox_maDV_PGT.Text;
            string tenDV = tenDV_PGT_cbb.Text;
            string kyHan = kyHan_num_PGT_cbb.Text;
            string laiSuat = laiSuat_PGT_cbb.Text;
            string denHan = denHan_PGT_tb.Text;
            int tienLai = 0;

            string soTienGui = soTienGui_PGT_tb.Text;

            string ngayrut = "";

            Console.WriteLine("Ngay gui: " + ngayGui);
            Console.WriteLine("Ngay den han: " + denHan);
            Console.WriteLine("maDV: " + maDV);
            Console.WriteLine("maGDV: " + maGDV_LPG);
            Console.WriteLine("tien gui: " + soTienGui);

           

            if (InsertPhieu(maPhieu, cmnd, maDV, ngayGui, laiSuat, soTienGui, maGDV_LPG, denHan, tienLai))
            {
                MessageBox.Show("Ghi Phiếu Thành Công");
            }
            else
            {
                MessageBox.Show("Ghi Phiếu that bai");
            }




        }

        bool InsertPhieu(string maPhieu, string cmnd, string maDV, string ngayGui, string laiSuat, string soTienGui, string maGDV_LPG, string ngayDenHan, int tienLai)                                                              //MAPHIEU,CMND,MADV,NGAYGUI,LAISUAT,SOTIEN_GUI,NGAYDENHAN,MAGDV_LPG,NGAYRUT,TIENLAI,MAGDV_LPR
        {
            string query = String.Format("INSERT INTO PHIEU (MAPHIEU,CMND,MADV,NGAYGUI,LAISUAT,SOTIEN_GUI,NGAYDENHAN,MAGDV_LPG,NGAYRUT,TIENLAI,MAGDV_LPR) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}', '{7}', '{8}', {9}, '{10}')", maPhieu, cmnd, maDV, ngayGui, laiSuat, soTienGui, ngayDenHan, maGDV_LPG , ngayDenHan, tienLai, maGDV_LPG);
                     
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        

        private void PhieuGuiTien_Load(object sender, EventArgs e)
        {

            loadmaGDV();
            // TODO: This line of code loads data into the 'qLTKDataSet.LAISUAT' table. You can move, or remove it, as needed.
            this.lAISUATTableAdapter.Fill(this.qLTKDataSet.LAISUAT);
            // TODO: This line of code loads data into the 'qLTKDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qLTKDataSet.DICHVU);

        }

        public DataTable getmaGDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAODICHVIEN ");
            return data;
        }

        public void loadmaGDV()
        {
            for(int i =0; i< getmaGDV().Rows.Count; i++)
            {
                maGDV_PGT_cbb.Items.Add(getmaGDV().Rows[i]["MAGDV"]);
            }
        }

        private void kyHan_num_PGT_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDate();
        }

        public void calculateDate()
        {
            DateTime ngaygui = dateTimePicker_ngayGui_PGT.Value;
            int kyHan = Int32.Parse(kyHan_num_PGT_cbb.Text);
            Console.WriteLine(kyHan);

            DateTime hannhan = ngaygui.AddMonths(kyHan);

            denHan_PGT_tb.Text = hannhan.ToString("d");
        }

        private void PhieuGuiTien_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void maGDV_PGT_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGDV_LPG = maGDV_PGT_cbb.SelectedItem.ToString();
            Console.WriteLine(maGDV_LPG);
        }

        private void dateTimePicker_ngayGui_PGT_ValueChanged(object sender, EventArgs e)
        {
            calculateDate();
        }

        private void comboBox_maDV_PGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSKH dskh = new DSKH();
            dskh.Show();
        }

        private void lapphieumoi_PGT_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
