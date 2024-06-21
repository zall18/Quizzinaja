using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzinAja
{
    static class Connection
    {

        public static SqlConnection conn;
        public static string connection = "Data Source=ERPEEL\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;MultipleActiveResultSets=True";

        public static SqlConnection Connect()
        {
            if(conn == null)
            {
                conn = new SqlConnection(connection);
            }

            return conn;
        }

    }
}
