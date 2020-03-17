using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login.DAL
{
    class DALContato
    {
        private ConexaoCliente objConexao;
        public DALContato(ConexaoCliente conexao)
        {
            objConexao = conexao;
        }
        public void Incluir(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into contato (con_cnpj,con_nome,con_telefone1,con_telefone2," +
                "con_celular,con_email)values" +
                " (@cnpj,@nome,@telefone1,@telefone2,@celular,@email);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cnpj", contato.Cnpj);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@telefone1", contato.Telefone1);
            cmd.Parameters.AddWithValue("@telefone2", contato.Telefone2);
            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
        public void Alterar(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update contato set con_cnpj=@cnpj,con_nome=@nome,con_telefone1=@telefone1,con_telefone2=@telefone2," +
                "con_celular=@celular,con_email=@email where con_codigo=@codigo";
            cmd.Parameters.AddWithValue("@cnpj", contato.Cnpj);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@telefone1", contato.Telefone1);
            cmd.Parameters.AddWithValue("@telefone2", contato.Telefone2);
            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from contato where con_codigo=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from contato where con_nome like '%" +
                valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public Contato carregaContato(int codigo)
        {
            Contato modelo = new Contato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from contato where con_codigo =" + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["con_codigo"]);
                modelo.Cnpj = Convert.ToString(registro["con_cnpj"]);
                modelo.Nome = Convert.ToString(registro["con_nome"]);
                modelo.Telefone1 = Convert.ToString(registro["con_Telefone1"]);
                modelo.Telefone2 = Convert.ToString(registro["con_Telefone2"]);
                modelo.Celular = Convert.ToString(registro["con_celular"]);
                modelo.Email = Convert.ToString(registro["con_email"]);
            }
            return modelo;
        }
    }
}
