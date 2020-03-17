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
    public partial class consultaContato : Form
    {
        public int codigo = 0;
        public consultaContato()
        {
            InitializeComponent();
        }

        private void consultaContato_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ConexaoCliente cx = new ConexaoCliente("Data Source=DESKTOP-IM6U0AK;Initial Catalog=Agenda;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txbValor.Text);
        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }

        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
