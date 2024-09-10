using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUANLYNHASACH
{
    class ConnSQL
    {
        public SqlConnection KetNoiCSDL()
        {
            string stringconn;
            if (User.Role == 2)
            {
                stringconn = "Data Source = (local); Initial Catalog = QL_NHASACH; Persist Security Info = True; User ID = sa; Password = 123456";
                
            }
            else stringconn = "Data Source= (local); Initial Catalog = QL_NHASACH ; Integrated Security = True";
            
            SqlConnection conn = new SqlConnection(stringconn);
            
            return conn;
            //Data Source = LAPTOP - 7KSFUUCL\SQLEXPRESS; Initial Catalog = QL_NHASACH; Integrated Security = True
        }
   
    }
}

