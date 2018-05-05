using ProjModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjController
{
   public  class ControllerMensagem

    {

       // ConnectionSQLServer conexao;
        SqlConnection con;

        public ControllerMensagem()
        {

            con = new SqlConnection
            (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);


            //con = conexao.getConnectionSqlServer();
            //con.Open();


        }

        public bool Insert(Mensagem msg)
        {

            bool status = false;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DBO.PR_INSERIR_MENSAGEM";
            cmd.Parameters.Add(new SqlParameter("@Descricao", msg.Descricao));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            return true;

        }

    }
}
