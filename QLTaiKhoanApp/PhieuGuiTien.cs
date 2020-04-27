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
            Application.Exit();
        }

        private void PhieuGuiTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình này? Mọi thông tin sẽ không được lưu lại", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void ghi_PGT_btn_Click(object sender, EventArgs e)
        {
            //string maPhieu = maPhieu_PGT_tb.Text;
            //string ngayGui = dateTimePicker_ngayGui_PGT.Value.ToString();
            string maKH = maKH_PGT_tb.Text;
            //string maGDV = maGDV_PGT_cbb.SelectedItem.ToString();
            string tenKH = tenKH_PGT_tb.Text;
            string diachi = diachi_PGT_tb.Text;
            string ngaysinh = dateTimePicker_ngaySinh_PGT.Value.ToString();
            string cmnd = cmnd_PGT_tb.Text;
            string ngaycap = dateTimePicker_ngayCap_PGT.Value.ToString();
            /*
            string maDV = comboBox_maDV_PGT.SelectedItem.ToString();
            string tenDV = tenDV_PGT_cbb.SelectedItem.ToString();
            string kyHan = kyHan_num_PGT_cbb.SelectedItem.ToString();
            string laiSuat = laiSuat_PGT_cbb.SelectedItem.ToString();
            string denHan = denHan_PGT_tb.Text;
            */

            string sotienGui = soTienGui_PGT_tb.Text;
            Console.WriteLine(getmaGDV().Rows[0]["MACN"].ToString());
            InsertKH(tenKH, ngaycap, cmnd, diachi, getmaGDV().Rows[0]["MACN"].ToString());


        }

        public void InsertKH(string hoten, string ngaycap, string cmnd, string diachi, string maCN)
        {
            string query = String.Format("INSERT INTO KHACHHANG VALUES(N'{0}', N'{1}', '{2}', '{3}', '{4}'", hoten, diachi, cmnd, ngaycap, maCN);

            SqlConnection conn = new SqlConnection(@"Data Source =" + DataProvider.getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd);
            SqlCommand comm;
            Console.WriteLine(DataProvider.getDtb(LoginForm.chinhanh));
            Console.WriteLine(LoginForm.uname);
            Console.WriteLine(LoginForm.passwd);

            conn.Open();
            comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Them KH Thanh công");
            conn.Close();
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
            string ngaydenhan = denHan_PGT_tb.Text;
            int kyHan = Int32.Parse(kyHan_num_PGT_cbb.Text);

            DateTime hannhan = ngaygui.AddMonths(kyHan);

            denHan_PGT_tb.Text = hannhan.ToString();
        }

        private void PhieuGuiTien_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }
    }
}
