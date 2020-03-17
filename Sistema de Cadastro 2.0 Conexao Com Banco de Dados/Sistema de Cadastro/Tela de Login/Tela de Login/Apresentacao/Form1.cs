using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_de_Login.Apresentacao;
using Tela_de_Login.Modelo;

namespace Tela_de_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            if (txbSenha.Text == "Senha")
            {
                txbSenha.Text = "";
            }
            
           
        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CadastroCliente tela = new CadastroCliente();
                tela.ShowDialog();
                tela.Dispose();
            }
            else
            {
                MessageBox.Show("Login não econtrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {
            if(txbLogin.Text == "Login")
            {
                txbLogin.Text = "";
            }

        }
    }
}
