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
    public partial class LoginForm : Form
    {
        public static string chinhanh;
        public static string uname;
        public static string passwd;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void LoginForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public bool checklogin()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHINHANH");
            if(data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            chinhanh = Login_chinhanh_cbb.SelectedItem.ToString();
            uname = username.Text;
            passwd = password.Text;


            if (checklogin())
            {
                MainFormAdmin mainform = new MainFormAdmin();
                this.Hide();
                mainform.ShowDialog();
                this.Show();
            }

        }

        

        private void Login_chinhanh_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
