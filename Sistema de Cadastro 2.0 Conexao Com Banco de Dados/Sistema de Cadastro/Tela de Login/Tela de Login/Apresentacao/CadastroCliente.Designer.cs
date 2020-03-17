namespace Tela_de_Login.Apresentacao
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefon1 = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbCnpj = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone1 = new System.Windows.Forms.TextBox();
            this.pDados = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.txbTelefone2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Tela_de_Login.AgendaDataSet();
            this.contatoTableAdapter = new Tela_de_Login.AgendaDataSetTableAdapters.contatoTableAdapter();
            this.agendaDataSet1 = new Tela_de_Login.AgendaDataSet();
            this.tableAdapterManager1 = new Tela_de_Login.AgendaDataSetTableAdapters.TableAdapterManager();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.concodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contelefone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contelefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.pDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.LightGray;
            this.lblCodigo.Location = new System.Drawing.Point(24, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.LightGray;
            this.lblCnpj.Location = new System.Drawing.Point(24, 51);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(51, 13);
            this.lblCnpj.TabIndex = 1;
            this.lblCnpj.Text = "* CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.LightGray;
            this.lblNome.Location = new System.Drawing.Point(25, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(141, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "* Razão Social / Nome:";
            // 
            // lblTelefon1
            // 
            this.lblTelefon1.AutoSize = true;
            this.lblTelefon1.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon1.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefon1.Location = new System.Drawing.Point(24, 106);
            this.lblTelefon1.Name = "lblTelefon1";
            this.lblTelefon1.Size = new System.Drawing.Size(81, 13);
            this.lblTelefon1.TabIndex = 3;
            this.lblTelefon1.Text = "* Telefone 1:";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefone2.Location = new System.Drawing.Point(24, 135);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(72, 13);
            this.lblTelefone2.TabIndex = 4;
            this.lblTelefone2.Text = "Telefone 2:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.LightGray;
            this.lblCelular.Location = new System.Drawing.Point(25, 160);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 13);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.LightGray;
            this.lblEmail.Location = new System.Drawing.Point(25, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCodigo.Location = new System.Drawing.Point(27, 28);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(51, 13);
            this.txbCodigo.TabIndex = 7;
            // 
            // txbCnpj
            // 
            this.txbCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCnpj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCnpj.Location = new System.Drawing.Point(77, 50);
            this.txbCnpj.Name = "txbCnpj";
            this.txbCnpj.Size = new System.Drawing.Size(143, 13);
            this.txbCnpj.TabIndex = 8;
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbNome.Location = new System.Drawing.Point(165, 77);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(314, 13);
            this.txbNome.TabIndex = 9;
            // 
            // txbTelefone1
            // 
            this.txbTelefone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTelefone1.Location = new System.Drawing.Point(104, 104);
            this.txbTelefone1.Name = "txbTelefone1";
            this.txbTelefone1.Size = new System.Drawing.Size(113, 13);
            this.txbTelefone1.TabIndex = 10;
            // 
            // pDados
            // 
            this.pDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.pDados.Controls.Add(this.panel8);
            this.pDados.Controls.Add(this.panel7);
            this.pDados.Controls.Add(this.panel6);
            this.pDados.Controls.Add(this.panel5);
            this.pDados.Controls.Add(this.panel4);
            this.pDados.Controls.Add(this.panel3);
            this.pDados.Controls.Add(this.panel1);
            this.pDados.Controls.Add(this.textBox2);
            this.pDados.Controls.Add(this.lblCodigo);
            this.pDados.Controls.Add(this.txbEmail);
            this.pDados.Controls.Add(this.lblCnpj);
            this.pDados.Controls.Add(this.txbCelular);
            this.pDados.Controls.Add(this.lblNome);
            this.pDados.Controls.Add(this.txbTelefone2);
            this.pDados.Controls.Add(this.lblTelefon1);
            this.pDados.Controls.Add(this.txbTelefone1);
            this.pDados.Controls.Add(this.lblTelefone2);
            this.pDados.Controls.Add(this.txbNome);
            this.pDados.Controls.Add(this.lblCelular);
            this.pDados.Controls.Add(this.txbCnpj);
            this.pDados.Controls.Add(this.lblEmail);
            this.pDados.Controls.Add(this.txbCodigo);
            this.pDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pDados.Location = new System.Drawing.Point(20, 12);
            this.pDados.Name = "pDados";
            this.pDados.Size = new System.Drawing.Size(832, 253);
            this.pDados.TabIndex = 14;
            this.pDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pDados_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(28, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 1);
            this.panel8.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(28, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 1);
            this.panel7.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(28, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 1);
            this.panel6.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(28, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 1);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(28, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 1);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(28, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 1);
            this.panel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 1);
            this.panel1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(367, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 15;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbEmail.Location = new System.Drawing.Point(69, 183);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(204, 13);
            this.txbEmail.TabIndex = 13;
            // 
            // txbCelular
            // 
            this.txbCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCelular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCelular.Location = new System.Drawing.Point(76, 159);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(134, 13);
            this.txbCelular.TabIndex = 12;
            // 
            // txbTelefone2
            // 
            this.txbTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTelefone2.Location = new System.Drawing.Point(97, 133);
            this.txbTelefone2.Name = "txbTelefone2";
            this.txbTelefone2.Size = new System.Drawing.Size(113, 13);
            this.txbTelefone2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social / Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnLocalizar);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Location = new System.Drawing.Point(20, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 54);
            this.panel2.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(581, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(499, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 29);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(417, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 29);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(335, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 29);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.Location = new System.Drawing.Point(253, 12);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(76, 29);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(171, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(76, 29);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataMember = "contato";
            this.contatoBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatoTableAdapter
            // 
            this.contatoTableAdapter.ClearBeforeFill = true;
            // 
            // agendaDataSet1
            // 
            this.agendaDataSet1.DataSetName = "AgendaDataSet";
            this.agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.contatoTableAdapter = this.contatoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Tela_de_Login.AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.AllowUserToOrderColumns = true;
            this.dgDados.AutoGenerateColumns = false;
            this.dgDados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concodigoDataGridViewTextBoxColumn,
            this.concnpjDataGridViewTextBoxColumn,
            this.connomeDataGridViewTextBoxColumn,
            this.contelefone1DataGridViewTextBoxColumn,
            this.contelefone2DataGridViewTextBoxColumn,
            this.concelularDataGridViewTextBoxColumn,
            this.conemailDataGridViewTextBoxColumn});
            this.dgDados.DataSource = this.contatoBindingSource;
            this.dgDados.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgDados.Location = new System.Drawing.Point(20, 321);
            this.dgDados.MultiSelect = false;
            this.dgDados.Name = "dgDados";
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgDados.Size = new System.Drawing.Size(832, 222);
            this.dgDados.TabIndex = 17;
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellDoubleClick);
            // 
            // concodigoDataGridViewTextBoxColumn
            // 
            this.concodigoDataGridViewTextBoxColumn.DataPropertyName = "con_codigo";
            this.concodigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.concodigoDataGridViewTextBoxColumn.Name = "concodigoDataGridViewTextBoxColumn";
            this.concodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.concodigoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.concodigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // concnpjDataGridViewTextBoxColumn
            // 
            this.concnpjDataGridViewTextBoxColumn.DataPropertyName = "con_cnpj";
            this.concnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ ";
            this.concnpjDataGridViewTextBoxColumn.Name = "concnpjDataGridViewTextBoxColumn";
            this.concnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.concnpjDataGridViewTextBoxColumn.Width = 107;
            // 
            // connomeDataGridViewTextBoxColumn
            // 
            this.connomeDataGridViewTextBoxColumn.DataPropertyName = "con_nome";
            this.connomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.connomeDataGridViewTextBoxColumn.Name = "connomeDataGridViewTextBoxColumn";
            this.connomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.connomeDataGridViewTextBoxColumn.Width = 190;
            // 
            // contelefone1DataGridViewTextBoxColumn
            // 
            this.contelefone1DataGridViewTextBoxColumn.DataPropertyName = "con_telefone1";
            this.contelefone1DataGridViewTextBoxColumn.HeaderText = "Telefone 1";
            this.contelefone1DataGridViewTextBoxColumn.Name = "contelefone1DataGridViewTextBoxColumn";
            this.contelefone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contelefone2DataGridViewTextBoxColumn
            // 
            this.contelefone2DataGridViewTextBoxColumn.DataPropertyName = "con_telefone2";
            this.contelefone2DataGridViewTextBoxColumn.HeaderText = "Telefone 2";
            this.contelefone2DataGridViewTextBoxColumn.Name = "contelefone2DataGridViewTextBoxColumn";
            this.contelefone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concelularDataGridViewTextBoxColumn
            // 
            this.concelularDataGridViewTextBoxColumn.DataPropertyName = "con_celular";
            this.concelularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.concelularDataGridViewTextBoxColumn.Name = "concelularDataGridViewTextBoxColumn";
            this.concelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conemailDataGridViewTextBoxColumn
            // 
            this.conemailDataGridViewTextBoxColumn.DataPropertyName = "con_email";
            this.conemailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.conemailDataGridViewTextBoxColumn.Name = "conemailDataGridViewTextBoxColumn";
            this.conemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.conemailDataGridViewTextBoxColumn.Width = 142;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(23, 314);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(445, 1);
            this.panel9.TabIndex = 19;
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValor.ForeColor = System.Drawing.SystemColors.Window;
            this.txbValor.Location = new System.Drawing.Point(20, 299);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(447, 13);
            this.txbValor.TabIndex = 18;
            this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(874, 622);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.pDados.ResumeLayout(false);
            this.pDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefon1;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbCnpj;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone1;
        private System.Windows.Forms.Panel pDados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private AgendaDataSetTableAdapters.contatoTableAdapter contatoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.TextBox txbTelefone2;
        private AgendaDataSet agendaDataSet1;
        private AgendaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn concodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contelefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contelefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbValor;
    }
}