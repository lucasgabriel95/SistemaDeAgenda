using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login.DAL
{
    class Contato
    {
        public Contato ()
        {
            this.Codigo = 0;
            this.Cnpj = "";
            this.Nome = "";
            this.Telefone1 = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Email = "";


        }
        public Contato (int codigo,string cnpj,string nome, string telefone1,string telefone2,string celular,string email )
        {
            this.Codigo = codigo;
            this.Cnpj = cnpj;
            this.Nome = nome;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Celular = celular;
            this.Email = email;
        }
        private int con_cod;
        public int Codigo
        {
            get
            {
                return this.con_cod;
            }
            set
            {
                this.con_cod = value;
            }
        }
        private string con_cnpj;
        public string Cnpj
        {
            get
            {
                return this.con_cnpj;
            }
            set
            {
                this.con_cnpj = value;
            }
        }
        private string con_nome;
        public string Nome
        {
            get
            {
                return this.con_nome;
            }
            set
            {
                this.con_nome = value;
            }
        }
        private string cong_telefone1;
        public string Telefone1
        {
            get
            {
                return this.cong_telefone1;
            }
            set
            {
                this.cong_telefone1 = value;
            }
        }
        private string cong_telefone2;
        public string Telefone2
        {
            get
            {
                return this.cong_telefone2;
            }
            set
            {
                this.cong_telefone2 = value;
            }
        }
        private string con_celular;
        public string Celular
        {
            get
            {
                return this.con_celular;
            }
            set
            {
                this.con_celular = value;
            }
        }
        private string con_email;
        public string Email
        {
            get
            {
                return this.con_email;
            }
            set
            {
                this.con_email = value;
            }
        }
    }
}
