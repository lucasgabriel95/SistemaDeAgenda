using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login.DAL
{
    class ConexaoCliente
    {
        private String _stringConexao;
        private SqlConnection _conexaoCliente;

        public ConexaoCliente (string dadosConexao)
        {
            this._conexaoCliente = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexaoCliente.ConnectionString = dadosConexao;
        }
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexaoCliente; }
            set { this._conexaoCliente = value; }
        }
        public void Conectar ()
        {
            this._conexaoCliente.Open();
        }
        public void Desconectar ()
        {
            this._conexaoCliente.Close();
        }
    
    }
}
