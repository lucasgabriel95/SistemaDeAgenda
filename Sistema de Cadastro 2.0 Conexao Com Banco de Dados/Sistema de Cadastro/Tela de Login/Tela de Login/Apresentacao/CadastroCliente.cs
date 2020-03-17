using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_de_Login.DAL;

namespace Tela_de_Login.Apresentacao
{
    public partial class CadastroCliente : Form
    {
        public int codigo = 0;
        public string opc = "1";
        public string operacao = "";
        public CadastroCliente()
        {
            InitializeComponent();
        }
        public void AlterarBotoes (int op)
        {
            pDados.Enabled = false;
            btnInserir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }
        public void LimpaCampos()
        {
            txbCodigo.Clear();
            txbCnpj.Clear();
            txbNome.Clear();
            txbTelefone1.Clear();
            txbTelefone2.Clear();
            txbCelular.Clear();
            txbEmail.Clear();
        }
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSet.contato'. Você pode movê-la ou removê-la conforme necessário.
          //  this.contatoTableAdapter.Fill(this.agendaDataSet.contato);
            this.AlterarBotoes(1);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
            ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
            DALContato dall = new DALContato(cx);
            dgDados.DataSource = dall.Localizar(txbValor.Text);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
            this.LimpaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txbCnpj.Text != "" && txbNome.Text != "" && txbTelefone1.Text != "")
            {
                DialogResult d;
                
                if (operacao == "inserir")
                {
                    d = MessageBox.Show("Deseja Cadastrar Cliente ?", "Aviso", MessageBoxButtons.YesNo);
                }
                else 
                {
                    d = MessageBox.Show("Deseja Alterar Cadastro ?", "Aviso", MessageBoxButtons.YesNo);
                }
                if (d.ToString() == "Yes")
                {
                    Contato contato = new Contato();
                    {
                        contato.Cnpj = txbCnpj.Text;
                        contato.Nome = txbNome.Text;
                        contato.Telefone1 = txbTelefone1.Text;
                        contato.Telefone2 = txbTelefone2.Text;
                        contato.Celular = txbCelular.Text;
                        contato.Email = txbEmail.Text;
                        String strConexao = "Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True";
                        ConexaoCliente conexao = new ConexaoCliente(strConexao);
                        DALContato dal = new DALContato(conexao);
                        if (this.operacao == "inserir")
                        {
                            dal.Incluir(contato);
                            MessageBox.Show("O codigo gerado foi: " + contato.Codigo.ToString());
                        }
                        else
                        {
                            contato.Codigo = Convert.ToInt32(txbCodigo.Text);
                            dal.Alterar(contato);
                        }
                        this.AlterarBotoes(1);
                        this.LimpaCampos();
                    }

                    ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
                    DALContato dall = new DALContato(cx);
                    dgDados.DataSource = dall.Localizar(txbValor.Text);

                }
                    
            }
            else
            {
                MessageBox.Show("Os campos obrigatorios não podem ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txbValor.Text);            

        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
                if (e.ColumnIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        codigo = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value);
                    }                   
                }
                if (codigo != 0)
                {
                    String strConexao = "Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True";
                    ConexaoCliente conexao = new ConexaoCliente(strConexao);
                    DALContato dall = new DALContato(conexao);
                    Contato contato = dall.carregaContato(codigo);
                    txbCodigo.Text = contato.Codigo.ToString();
                    txbCnpj.Text = contato.Cnpj;
                    txbNome.Text = contato.Nome;
                    txbTelefone1.Text = contato.Telefone1;
                    txbTelefone2.Text = contato.Telefone2;
                    txbCelular.Text = contato.Celular;
                    txbEmail.Text = contato.Email;
                    this.AlterarBotoes(3);
                }
            



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir o registro ?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString()== "Yes")
            {
                String strConexao = "Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True";
                ConexaoCliente conexao = new ConexaoCliente(strConexao);
                DALContato dal = new DALContato(conexao);
                dal.Excluir(Convert.ToInt32(txbCodigo.Text));
                this.AlterarBotoes(1);
                this.LimpaCampos();
                ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
                DALContato dall = new DALContato(cx);
                dgDados.DataSource = dall.Localizar(txbValor.Text);
            }
        }

        private void pDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txbValor.Text);
        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {
          if (txbValor.Text != "")
            {
                ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
                DALContato dal = new DALContato(cx);
                dgDados.DataSource = dal.Localizar(txbValor.Text);
            }
          else if (txbValor.Text == "")
            {
                ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-788MSMO;Initial Catalog=Logins;Integrated Security=True");
                DALContato dal = new DALContato(cx);
                dgDados.DataSource = dal.Localizar(txbValor.Text);

            }
           
        }
    }
}
