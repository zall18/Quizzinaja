using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzinAja
{
    static class session
    {

        public static int id_user;
        public static string nama_user;

        public static void start(int id, string nama)
        {
            id_user = id;
            nama_user = nama;
        }

        public static void stop(int id)
        {
            id_user = 0;
            nama_user = null;
        }

    }
}
