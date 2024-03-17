using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Магазин_техники
{
    public class db
    {
        SqlConnection connection = new SqlConnection("Server=sql;Database=УП07_ИСП2_Кузнецов;Trusted_Connection=True;TrustServerCertificate=True");

        public void openconn()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeconn()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getconn()
        {
            return connection;
        }

    }
}
