using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTaiKhoanApp.DAO
{
    public class DataProvider
    {
        //Singleton
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        public static string getDtb(string data)
        {
            if (data.Equals("CHI NHÁNH QUẬN 1"))
                return @"LAPTOP-U8OGNL07\MSSQL_SEVER1";
            else if (data.Equals("CHI NHÁNH QUẬN 2"))
                return @"LAPTOP-U8OGNL07\MSSQL_SERVER2";
            else if (data.Equals("ADMIN"))
                return @"LAPTOP-U8OGNL07\MSSQLSERVER_V001";
            return "";
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] element = null)
        {
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname+ ";Password=" + LoginForm.passwd;
            DataTable data = new DataTable();
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }
                conn.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

            }
            return data;
        }

        //Kiểm tra insert
        public int ExecuteNonQuery(string query, object[] element = null)
        {
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd;
            int data = 0;
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }




                data = command.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        //Lấy dữ liệu đầu tiên
        public object ExecuteScalar(string query, object[] element = null)
        {
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd;
            object data = 0;
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
