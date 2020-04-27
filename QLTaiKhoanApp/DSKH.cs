using QLTaiKhoanApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTaiKhoanApp
{
    public partial class DSKH : Form
    {
        public DSKH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DSKH_Load(object sender, EventArgs e)
        {
            loadDSKH();
            loadCN();
        }

        public void loadDSKH()
        {
            string query = "SELECT * FROM KHACHHANG";
            dataGridView_DSKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tenKH = ten_DSKH_tb.Text;
            string cmnd = cmnd_DSKH_tb.Text;
            string ngaycap = dateTimePicker_DSKH_ngaycap.Value.ToString();
            string diachi = diachi_DSKH_tb.Text;

            
            if (InsertKH(tenKH, ngaycap, cmnd, diachi, getmaGDV().Rows[0]["MACN"].ToString()))
            {
                Console.WriteLine("Insert KH thanh cong");
                loadDSKH();
                ten_DSKH_tb.Clear();
                cmnd_DSKH_tb.Clear();
                diachi_DSKH_tb.Clear();
            }
            else
            {
                Console.WriteLine("Insert KH that bai");
            }
            
        }

        public void loadCN()
        {
            chinhnah_DSKH_tb.Text = getmaGDV().Rows[0]["MACN"].ToString();
        } 


        public DataTable getmaGDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAODICHVIEN ");
            return data;
        }

        bool InsertKH(string hoten, string ngaycap, string cmnd, string diachi, string maCN)
        {
            string query = String.Format("INSERT INTO KHACHHANG (HOTEN,DIACHI,CMND,NGAYCAP,MACN) VALUES (N'{0}', N'{1}', '{2}', '{3}','{4}')", hoten, diachi, cmnd, ngaycap, maCN);
            
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            

            return result > 0;
        }

        private void thoat_DSKH_btn_Click(object sender, EventArgs e)
        {
            MainFormAdmin lgf = new MainFormAdmin();
            this.Hide();
            lgf.Show();
        }
    }
}
