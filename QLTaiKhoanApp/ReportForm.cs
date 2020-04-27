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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            loadPhieu();
        }

        public void loadPhieu()
        {
            string query = "SELECT * FROM PHIEU";
            dataGridView_report.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
