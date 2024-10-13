using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataBase
    {
        public static string Connection
        {
            get
            {
                return ConfigurationManager.
                    ConnectionStrings["P02ConnectionString"].
                    ConnectionString;
            }


        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(Connection);

            connection.Open();
            return connection;

        }

    }


}
