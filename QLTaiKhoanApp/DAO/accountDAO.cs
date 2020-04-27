using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTaiKhoanApp.DAO
{
    public class accountDAO
    {
        private static accountDAO instance;
        public static accountDAO Instance
        {
            get { if (instance == null) instance = new accountDAO(); return instance; }
            private set { instance = value; }
        }

        private accountDAO() { }

    }
}
