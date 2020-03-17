using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao ()
        {
            con.ConnectionString = @"Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True";
        }

        // verify that the databese is open and connect
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //verify that the databese is close and disconnect
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
