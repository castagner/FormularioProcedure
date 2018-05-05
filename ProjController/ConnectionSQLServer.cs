using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjController
{
    public class ConnectionSQLServer
    {

        SqlConnection con;

        public SqlConnection getConnectionSqlServer()
        {

            string _conexao = ConfigurationManager.ConnectionStrings["SQLSERVER"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = _conexao;
            return con;

        }

    }
}
