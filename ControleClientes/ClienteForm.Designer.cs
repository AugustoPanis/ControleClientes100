namespace ControleClientes
{
    partial class ClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            tpClienteCadastro = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            cmbCidade = new ComboBox();
            label1 = new Label();
            txtUf = new TextBox();
            txtNome = new TextBox();
            txtBairro = new TextBox();
            txtEmail = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            btnSalvar = new Button();
            label8 = new Label();
            btnCancelar = new Button();
            label7 = new Label();
            cmbGenero = new ComboBox();
            label6 = new Label();
            labelGenero = new Label();
            label5 = new Label();
            cmbEstadoCivil = new ComboBox();
            label3 = new Label();
            labelEstadoCivil = new Label();
            label4 = new Label();
            txtCEP = new Label();
            txtLogradouro = new TextBox();
            textCEP = new MaskedTextBox();
            btnCep = new Button();
            tpClienteConsulta = new TabPage();
            gridClientes = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            pnlSuperior = new Panel();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            pnlInferior = new Panel();
            button1 = new Button();
            btnExcluirdaGrid = new Button();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tcCliente = new TabControl();
            tpClienteCadastro.SuspendLayout();
            panel1.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            pnlSuperior.SuspendLayout();
            pnlInferior.SuspendLayout();
            tcCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.BackColor = Color.LightGray;
            tpClienteCadastro.Controls.Add(panel1);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(627, 263);
            tpClienteCadastro.TabIndex = 2;
            tpClienteCadastro.Text = "Cadastro";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbCidade);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUf);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(txtComplemento);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelGenero);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbEstadoCivil);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelEstadoCivil);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCEP);
            panel1.Controls.Add(txtLogradouro);
            panel1.Controls.Add(textCEP);
            panel1.Controls.Add(btnCep);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 257);
            panel1.TabIndex = 36;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 11);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(23, 117);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(151, 23);
            cmbCidade.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 11);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(145, 72);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(29, 23);
            txtUf.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(156, 23);
            txtNome.TabIndex = 0;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(343, 73);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(109, 23);
            txtBairro.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(458, 74);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(106, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(183, 117);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(154, 23);
            txtComplemento.TabIndex = 7;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(531, 234);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(145, 55);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 35;
            label8.Text = "UF";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(0, 234);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 99);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 34;
            label7.Text = "Cidade";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(346, 29);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(106, 23);
            cmbGenero.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 55);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 33;
            label6.Text = "Bairro";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(346, 11);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 15;
            labelGenero.Text = "Gênero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 99);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 32;
            label5.Text = "Complemento";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(458, 29);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(106, 23);
            cmbEstadoCivil.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 55);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 31;
            label3.Text = "Número";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Location = new Point(458, 11);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(68, 15);
            labelEstadoCivil.TabIndex = 17;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 55);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 30;
            label4.Text = "Rua";
            // 
            // txtCEP
            // 
            txtCEP.AutoSize = true;
            txtCEP.Location = new Point(23, 55);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(28, 15);
            txtCEP.TabIndex = 18;
            txtCEP.Text = "CEP";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(183, 73);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(154, 23);
            txtLogradouro.TabIndex = 11;
            // 
            // textCEP
            // 
            textCEP.Location = new Point(23, 73);
            textCEP.Mask = "00000-000";
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(70, 23);
            textCEP.TabIndex = 4;
            // 
            // btnCep
            // 
            btnCep.Image = (Image)resources.GetObject("btnCep.Image");
            btnCep.Location = new Point(94, 72);
            btnCep.Name = "btnCep";
            btnCep.Size = new Size(40, 25);
            btnCep.TabIndex = 5;
            btnCep.UseVisualStyleBackColor = true;
            btnCep.Click += btnCep_Click;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlSuperior);
            tpClienteConsulta.Controls.Add(pnlInferior);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(627, 263);
            tpClienteConsulta.TabIndex = 1;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, ColNome, colemail });
            gridClientes.Dock = DockStyle.Fill;
            gridClientes.Location = new Point(3, 26);
            gridClientes.MultiSelect = false;
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.RowHeadersWidth = 51;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(621, 210);
            gridClientes.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColID.DataPropertyName = "Id";
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Resizable = DataGridViewTriState.True;
            ColID.Width = 43;
            // 
            // ColNome
            // 
            ColNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNome.DataPropertyName = "Nome";
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 6;
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colemail.DataPropertyName = "Email";
            colemail.HeaderText = "E-mail";
            colemail.MinimumWidth = 6;
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(txtPesquisa);
            pnlSuperior.Controls.Add(btnPesquisar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(3, 3);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(621, 23);
            pnlSuperior.TabIndex = 0;
            pnlSuperior.TabStop = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(0, 0);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar nomes";
            txtPesquisa.Size = new Size(523, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(522, -1);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 24);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(button1);
            pnlInferior.Controls.Add(btnExcluirdaGrid);
            pnlInferior.Controls.Add(btnVisualizar);
            pnlInferior.Controls.Add(btnNovo);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(3, 236);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(621, 24);
            pnlInferior.TabIndex = 0;
            pnlInferior.TabStop = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(74, 24);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExcluir_Click;
            // 
            // btnExcluirdaGrid
            // 
            btnExcluirdaGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirdaGrid.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirdaGrid.Location = new Point(-108, 0);
            btnExcluirdaGrid.Name = "btnExcluirdaGrid";
            btnExcluirdaGrid.Size = new Size(74, 24);
            btnExcluirdaGrid.TabIndex = 2;
            btnExcluirdaGrid.Text = "Excluir";
            btnExcluirdaGrid.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluirdaGrid.UseVisualStyleBackColor = true;
            btnExcluirdaGrid.Click += btnExcluir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(486, 0);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(74, 24);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.Location = new Point(561, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(60, 24);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(1, -22);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(635, 291);
            tcCliente.TabIndex = 0;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(630, 269);
            Controls.Add(tcCliente);
            Name = "ClienteForm";
            Text = "Cadastro de Cliente";
            tpClienteCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInferior.ResumeLayout(false);
            tcCliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpClienteCadastro;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TabPage tpClienteConsulta;
        private TabControl tcCliente;
        private DataGridView gridClientes;
        private Button btnVisualizar;
        private Button btnPesquisar;
        private Button btnNovo;
        private TextBox txtPesquisa;
        private Panel pnlInferior;
        private Panel pnlSuperior;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn colemail;
        private ComboBox cmbGenero;
        private Label labelGenero;
        private Label labelEstadoCivil;
        private ComboBox cmbEstadoCivil;
        private Label txtCEP;
        private MaskedTextBox textCEP;
        private Button btnCep;
        private TextBox txtUf;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtLogradouro;
        private ComboBox cmbCidade;
        private Button btnExcluirdaGrid;
        private Panel panel1;
        private Button button1;
    }
}