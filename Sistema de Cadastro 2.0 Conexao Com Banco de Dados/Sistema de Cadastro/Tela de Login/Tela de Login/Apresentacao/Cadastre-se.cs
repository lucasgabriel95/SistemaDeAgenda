using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_de_Login.Modelo;

namespace Tela_de_Login.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(txbEmail.Text,txbSenha.Text,txbRepetirSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbEmail.Text = "";
                txbSenha.Text = "";
                txbRepetirSenha.Text = "";
            }
            else
            {
                MessageBox.Show(controle.mensagem);// messagem de erro. 
            }
            
        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {

        }

        private void lblRepetirSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbRepetirSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
