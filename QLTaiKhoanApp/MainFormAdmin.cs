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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuRutTien prt = new PhieuRutTien();
            prt.ShowDialog();

        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuGuiTien pgt = new PhieuGuiTien();
            pgt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSKH dskh = new DSKH();
            dskh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            rp.ShowDialog();
        }

        private void Exit_mainform_btn_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            this.Hide();
            lgf.Show();

        }
    }
}
