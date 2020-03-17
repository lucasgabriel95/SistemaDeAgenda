using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; // everything is OK// tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin (String login,String senha)
        {
            // search the database for login and password
            //pesquise no banco de dados por login e senha
            cmd.CommandText = "select * from logins where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);         

            try
            {
                cmd.Connection = con.Conectar();
               dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }


        public string cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //comandos para inserir
            if (email != "")
            {
                if (senha != "" & confSenha != "")
                {
                    if (senha.Equals(confSenha))
                    {
                        cmd.CommandText = "insert into logins values (@e,@s);";
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@s", senha);

                        try
                        {
                            cmd.Connection = con.Conectar();
                            cmd.ExecuteNonQuery();
                            con.desconectar();
                            this.mensagem = "Cadastrado com sucesso!";
                            tem = true;
                            
                        }
                        catch (SqlException)
                        {
                            this.mensagem = "Erro com banco de dados";
                            
                        }
                    }
                    else
                    {
                        this.mensagem = "senhas não correspondem!";
                    }
                }
                else
                {
                    this.mensagem = "Senha e Confirmar senha não pode ficar em branco!";
                }
            }
            


            return mensagem;
        }
    }
}
