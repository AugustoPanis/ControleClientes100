namespace ControleClientes
{
    partial class OsForm
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
            tabPageCadastroOS = new TabPage();
            textBoxQuantidade = new TextBox();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            textBoxValorTotal = new TextBox();
            textBoxValorCadastro = new TextBox();
            textBoxDescricao = new TextBox();
            labelTotal = new Label();
            labelQuantidade = new Label();
            labelValorTipo = new Label();
            comboBoxTipoOs = new ComboBox();
            labelTipoDeOrdem = new Label();
            labelDescricao = new Label();
            labelOs = new Label();
            comboBoxCliente = new ComboBox();
            labelCliente = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            OS = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            tabControlOS = new TabControl();
            tabPageConsultaOS = new TabPage();
            panelSuperior = new Panel();
            buttonPesquisar = new Button();
            textBoxPesquisarOs = new TextBox();
            panelInferior = new Panel();
            buttonExcluir = new Button();
            buttonTipo = new Button();
            buttonVizualizar = new Button();
            buttonNovo = new Button();
            dataGridOS = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColunaNome = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            ValorTotalGeral = new DataGridViewTextBoxColumn();
            tabPageCadastroOS.SuspendLayout();
            tabControlOS.SuspendLayout();
            tabPageConsultaOS.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOS).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastroOS
            // 
            tabPageCadastroOS.Controls.Add(textBoxQuantidade);
            tabPageCadastroOS.Controls.Add(comboBoxStatus);
            tabPageCadastroOS.Controls.Add(labelStatus);
            tabPageCadastroOS.Controls.Add(textBoxValorTotal);
            tabPageCadastroOS.Controls.Add(textBoxValorCadastro);
            tabPageCadastroOS.Controls.Add(textBoxDescricao);
            tabPageCadastroOS.Controls.Add(labelTotal);
            tabPageCadastroOS.Controls.Add(labelQuantidade);
            tabPageCadastroOS.Controls.Add(labelValorTipo);
            tabPageCadastroOS.Controls.Add(comboBoxTipoOs);
            tabPageCadastroOS.Controls.Add(labelTipoDeOrdem);
            tabPageCadastroOS.Controls.Add(labelDescricao);
            tabPageCadastroOS.Controls.Add(labelOs);
            tabPageCadastroOS.Controls.Add(comboBoxCliente);
            tabPageCadastroOS.Controls.Add(labelCliente);
            tabPageCadastroOS.Controls.Add(buttonCancelar);
            tabPageCadastroOS.Controls.Add(buttonSalvar);
            tabPageCadastroOS.Location = new Point(4, 24);
            tabPageCadastroOS.Name = "tabPageCadastroOS";
            tabPageCadastroOS.Padding = new Padding(3);
            tabPageCadastroOS.Size = new Size(644, 361);
            tabPageCadastroOS.TabIndex = 1;
            tabPageCadastroOS.Text = "tabPage2";
            tabPageCadastroOS.UseVisualStyleBackColor = true;
            tabPageCadastroOS.Click += tabPageCadastroOS_Click;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(311, 159);
            textBoxQuantidade.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(120, 23);
            textBoxQuantidade.TabIndex = 75;
            textBoxQuantidade.TextChanged += textBoxQuantidade_TextChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(168, 214);
            comboBoxStatus.Margin = new Padding(3, 2, 3, 2);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(168, 196);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 69;
            labelStatus.Text = "Status";
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(310, 214);
            textBoxValorTotal.Margin = new Padding(3, 2, 3, 2);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(121, 23);
            textBoxValorTotal.TabIndex = 12;
            textBoxValorTotal.TextChanged += textBoxValorTotal_TextChanged;
            // 
            // textBoxValorCadastro
            // 
            textBoxValorCadastro.Location = new Point(168, 158);
            textBoxValorCadastro.Margin = new Padding(3, 2, 3, 2);
            textBoxValorCadastro.Name = "textBoxValorCadastro";
            textBoxValorCadastro.Size = new Size(121, 23);
            textBoxValorCadastro.TabIndex = 61;
            textBoxValorCadastro.TextChanged += textBoxValorCadastro_TextChanged;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(168, 267);
            textBoxDescricao.Margin = new Padding(3, 2, 3, 2);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(263, 21);
            textBoxDescricao.TabIndex = 8;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(312, 196);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(62, 15);
            labelTotal.TabIndex = 64;
            labelTotal.Text = "Valor Total";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(312, 141);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 62;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelValorTipo
            // 
            labelValorTipo.AutoSize = true;
            labelValorTipo.Location = new Point(168, 141);
            labelValorTipo.Name = "labelValorTipo";
            labelValorTipo.Size = new Size(33, 15);
            labelValorTipo.TabIndex = 60;
            labelValorTipo.Text = "Valor";
            // 
            // comboBoxTipoOs
            // 
            comboBoxTipoOs.FormattingEnabled = true;
            comboBoxTipoOs.Location = new Point(310, 96);
            comboBoxTipoOs.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipoOs.Name = "comboBoxTipoOs";
            comboBoxTipoOs.Size = new Size(121, 23);
            comboBoxTipoOs.TabIndex = 10;
            comboBoxTipoOs.SelectedIndexChanged += comboBoxTipoOs_SelectedIndexChanged;
            // 
            // labelTipoDeOrdem
            // 
            labelTipoDeOrdem.AutoSize = true;
            labelTipoDeOrdem.Location = new Point(312, 79);
            labelTipoDeOrdem.Name = "labelTipoDeOrdem";
            labelTipoDeOrdem.Size = new Size(88, 15);
            labelTipoDeOrdem.TabIndex = 58;
            labelTipoDeOrdem.Text = "Tipo de Serviço";
            labelTipoDeOrdem.Click += labelTipoDeOrdem_Click;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(168, 250);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(58, 15);
            labelDescricao.TabIndex = 56;
            labelDescricao.Text = "Descrição";
            // 
            // labelOs
            // 
            labelOs.AutoSize = true;
            labelOs.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOs.Location = new Point(219, 31);
            labelOs.Name = "labelOs";
            labelOs.Size = new Size(151, 21);
            labelOs.TabIndex = 54;
            labelOs.Text = "Ordem de Serviço";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.Location = new Point(168, 97);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(121, 23);
            comboBoxCliente.TabIndex = 76;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCliente.Location = new Point(168, 73);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(65, 21);
            labelCliente.TabIndex = 17;
            labelCliente.Text = "Cliente";
            // 
            // buttonCancelar
            // 
            buttonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelar.Location = new Point(0, 318);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(84, 23);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(548, 332);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(90, 23);
            buttonSalvar.TabIndex = 14;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // OS
            // 
            OS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OS.HeaderText = "Id";
            OS.MinimumWidth = 6;
            OS.Name = "OS";
            OS.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // tabControlOS
            // 
            tabControlOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlOS.Controls.Add(tabPageConsultaOS);
            tabControlOS.Controls.Add(tabPageCadastroOS);
            tabControlOS.Location = new Point(-4, -23);
            tabControlOS.Name = "tabControlOS";
            tabControlOS.SelectedIndex = 0;
            tabControlOS.Size = new Size(652, 389);
            tabControlOS.TabIndex = 4;
            // 
            // tabPageConsultaOS
            // 
            tabPageConsultaOS.Controls.Add(panelSuperior);
            tabPageConsultaOS.Controls.Add(panelInferior);
            tabPageConsultaOS.Controls.Add(dataGridOS);
            tabPageConsultaOS.Location = new Point(4, 24);
            tabPageConsultaOS.Name = "tabPageConsultaOS";
            tabPageConsultaOS.Padding = new Padding(3);
            tabPageConsultaOS.Size = new Size(644, 361);
            tabPageConsultaOS.TabIndex = 0;
            tabPageConsultaOS.Text = "tabPage1";
            tabPageConsultaOS.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(buttonPesquisar);
            panelSuperior.Controls.Add(textBoxPesquisarOs);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(3, 3);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(638, 27);
            panelSuperior.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Dock = DockStyle.Right;
            buttonPesquisar.ForeColor = SystemColors.ControlText;
            buttonPesquisar.Image = Properties.Resources.search;
            buttonPesquisar.Location = new Point(550, 0);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(88, 27);
            buttonPesquisar.TabIndex = 1;
            buttonPesquisar.Text = "&Pesquisar";
            buttonPesquisar.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxPesquisarOs
            // 
            textBoxPesquisarOs.Dock = DockStyle.Left;
            textBoxPesquisarOs.Location = new Point(0, 0);
            textBoxPesquisarOs.Name = "textBoxPesquisarOs";
            textBoxPesquisarOs.PlaceholderText = "Pesquisar OS";
            textBoxPesquisarOs.Size = new Size(615, 23);
            textBoxPesquisarOs.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(buttonExcluir);
            panelInferior.Controls.Add(buttonTipo);
            panelInferior.Controls.Add(buttonVizualizar);
            panelInferior.Controls.Add(buttonNovo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(3, 330);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(638, 28);
            panelInferior.TabIndex = 2;
            panelInferior.Paint += panelInferior_Paint;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Dock = DockStyle.Left;
            buttonExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluir.Location = new Point(0, 0);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(85, 28);
            buttonExcluir.TabIndex = 17;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonTipo
            // 
            buttonTipo.Dock = DockStyle.Right;
            buttonTipo.Location = new Point(460, 0);
            buttonTipo.Margin = new Padding(3, 2, 3, 2);
            buttonTipo.Name = "buttonTipo";
            buttonTipo.Size = new Size(95, 28);
            buttonTipo.TabIndex = 2;
            buttonTipo.Text = "Novo Serviço";
            buttonTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTipo.UseVisualStyleBackColor = true;
            buttonTipo.Click += buttonTipo_Click;
            // 
            // buttonVizualizar
            // 
            buttonVizualizar.Dock = DockStyle.Fill;
            buttonVizualizar.Location = new Point(0, 0);
            buttonVizualizar.Name = "buttonVizualizar";
            buttonVizualizar.Size = new Size(555, 28);
            buttonVizualizar.TabIndex = 0;
            buttonVizualizar.Text = "Visualizar";
            buttonVizualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVizualizar.UseVisualStyleBackColor = true;
            buttonVizualizar.Click += buttonVizualizar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Dock = DockStyle.Right;
            buttonNovo.Location = new Point(555, 0);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(83, 28);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Nova OS";
            buttonNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // dataGridOS
            // 
            dataGridOS.AllowUserToAddRows = false;
            dataGridOS.AllowUserToOrderColumns = true;
            dataGridOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOS.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColunaNome, ColumnStatus, descricao, ValorTotalGeral });
            dataGridOS.Location = new Point(3, 33);
            dataGridOS.Name = "dataGridOS";
            dataGridOS.ReadOnly = true;
            dataGridOS.RowHeadersWidth = 51;
            dataGridOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOS.Size = new Size(636, 296);
            dataGridOS.TabIndex = 1;
            dataGridOS.CellContentClick += dataGridOS_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "iD";
            ColumnId.FillWeight = 53.47593F;
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColunaNome
            // 
            ColunaNome.DataPropertyName = "ColunaNome";
            ColunaNome.FillWeight = 111.63102F;
            ColunaNome.HeaderText = "Cliente";
            ColunaNome.MinimumWidth = 6;
            ColunaNome.Name = "ColunaNome";
            ColunaNome.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.DataPropertyName = "StatusNome";
            ColumnStatus.FillWeight = 111.63102F;
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "Descricao";
            descricao.FillWeight = 111.63102F;
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 6;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // ValorTotalGeral
            // 
            ValorTotalGeral.DataPropertyName = "ValorTotalGeral";
            ValorTotalGeral.FillWeight = 111.63102F;
            ValorTotalGeral.HeaderText = "Valor";
            ValorTotalGeral.MinimumWidth = 6;
            ValorTotalGeral.Name = "ValorTotalGeral";
            ValorTotalGeral.ReadOnly = true;
            // 
            // OsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 358);
            Controls.Add(tabControlOS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "OsForm";
            Text = "Cadastro de Ordem de Serviço";
            tabPageCadastroOS.ResumeLayout(false);
            tabPageCadastroOS.PerformLayout();
            tabControlOS.ResumeLayout(false);
            tabPageConsultaOS.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageCadastroOS;
        private TabControl tabControlOS;
        private DataGridViewTextBoxColumn OS;
        private DataGridViewTextBoxColumn Cliente;
        private TextBox textBoxValorTotal;
        private TextBox textBoxValorCadastro;
        private TextBox textBoxDescricao;
        private Label labelTotal;
        private Label labelQuantidade;
        private Label labelValorTipo;
        private ComboBox comboBoxTipoOs;
        private Label labelTipoDeOrdem;
        private Label labelDescricao;
        private Label labelOs;
        private ComboBox comboBoxCliente;
        private Label labelCliente;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private TabPage tabPageConsultaOS;
        private Panel panelSuperior;
        private Button buttonPesquisar;
        private TextBox textBoxPesquisarOs;
        private Panel panelInferior;
        private Button buttonTipo;
        private Button buttonVizualizar;
        private Button buttonNovo;
        private DataGridView dataGridOS;
        private ComboBox comboBoxStatus;
        private Label labelStatus;
        private TextBox textBoxQuantidade;
        private Button buttonExcluir;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColunaNome;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn ValorTotalGeral;
    }
}