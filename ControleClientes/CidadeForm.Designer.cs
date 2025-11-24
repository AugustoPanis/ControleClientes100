namespace ControleClientes
{
    partial class CidadeForm
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
            tabControlCidades = new TabControl();
            tabPageConsultaCidades = new TabPage();
            panelSuperior = new Panel();
            btnPesquisarCidade = new Button();
            txtPesquisaCidade = new TextBox();
            panelInferior = new Panel();
            btnExcluirDaGrid = new Button();
            btnVisualizarCidade = new Button();
            btnNovaCidade = new Button();
            dataGridCidade = new DataGridView();
            Cidade = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            tabPageCadastroCidades = new TabPage();
            label1 = new Label();
            btnCancelarCidade = new Button();
            btnSalvarCidade = new Button();
            textUF = new TextBox();
            textCidade = new TextBox();
            labelUF = new Label();
            labelCidade = new Label();
            tabControlCidades.SuspendLayout();
            tabPageConsultaCidades.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).BeginInit();
            tabPageCadastroCidades.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCidades
            // 
            tabControlCidades.Controls.Add(tabPageConsultaCidades);
            tabControlCidades.Controls.Add(tabPageCadastroCidades);
            tabControlCidades.Location = new Point(-4, -24);
            tabControlCidades.Name = "tabControlCidades";
            tabControlCidades.SelectedIndex = 0;
            tabControlCidades.Size = new Size(634, 340);
            tabControlCidades.TabIndex = 3;
            // 
            // tabPageConsultaCidades
            // 
            tabPageConsultaCidades.Controls.Add(panelSuperior);
            tabPageConsultaCidades.Controls.Add(panelInferior);
            tabPageConsultaCidades.Controls.Add(dataGridCidade);
            tabPageConsultaCidades.Location = new Point(4, 24);
            tabPageConsultaCidades.Name = "tabPageConsultaCidades";
            tabPageConsultaCidades.Padding = new Padding(3);
            tabPageConsultaCidades.Size = new Size(626, 312);
            tabPageConsultaCidades.TabIndex = 0;
            tabPageConsultaCidades.Text = "tabPage1";
            tabPageConsultaCidades.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnPesquisarCidade);
            panelSuperior.Controls.Add(txtPesquisaCidade);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(3, 3);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(620, 27);
            panelSuperior.TabIndex = 0;
            // 
            // btnPesquisarCidade
            // 
            btnPesquisarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarCidade.ForeColor = SystemColors.ControlText;
            btnPesquisarCidade.Image = Properties.Resources.search;
            btnPesquisarCidade.Location = new Point(506, 2);
            btnPesquisarCidade.Name = "btnPesquisarCidade";
            btnPesquisarCidade.Size = new Size(115, 26);
            btnPesquisarCidade.TabIndex = 1;
            btnPesquisarCidade.Text = "&Pesquisar";
            btnPesquisarCidade.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarCidade.UseVisualStyleBackColor = true;
            btnPesquisarCidade.Click += btnPesquisarCidade_Click;
            // 
            // txtPesquisaCidade
            // 
            txtPesquisaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaCidade.Location = new Point(3, 3);
            txtPesquisaCidade.Name = "txtPesquisaCidade";
            txtPesquisaCidade.PlaceholderText = "Pesquisar cidades";
            txtPesquisaCidade.Size = new Size(506, 23);
            txtPesquisaCidade.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnExcluirDaGrid);
            panelInferior.Controls.Add(btnVisualizarCidade);
            panelInferior.Controls.Add(btnNovaCidade);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(3, 281);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(620, 28);
            panelInferior.TabIndex = 2;
            // 
            // btnExcluirDaGrid
            // 
            btnExcluirDaGrid.Dock = DockStyle.Left;
            btnExcluirDaGrid.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirDaGrid.Location = new Point(0, 0);
            btnExcluirDaGrid.Name = "btnExcluirDaGrid";
            btnExcluirDaGrid.Size = new Size(66, 28);
            btnExcluirDaGrid.TabIndex = 2;
            btnExcluirDaGrid.Text = "Excluir";
            btnExcluirDaGrid.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluirDaGrid.UseVisualStyleBackColor = true;
            btnExcluirDaGrid.Click += btnExcluirCidade_Click;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Dock = DockStyle.Right;
            btnVisualizarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizarCidade.Location = new Point(494, 0);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(66, 28);
            btnVisualizarCidade.TabIndex = 0;
            btnVisualizarCidade.Text = "Visualizar";
            btnVisualizarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarCidade.UseVisualStyleBackColor = true;
            btnVisualizarCidade.Click += btnVisualizarCidade_Click;
            // 
            // btnNovaCidade
            // 
            btnNovaCidade.Dock = DockStyle.Right;
            btnNovaCidade.Location = new Point(560, 0);
            btnNovaCidade.Name = "btnNovaCidade";
            btnNovaCidade.Size = new Size(60, 28);
            btnNovaCidade.TabIndex = 1;
            btnNovaCidade.Text = "Novo";
            btnNovaCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaCidade.UseVisualStyleBackColor = true;
            btnNovaCidade.Click += btnNovaCidade_Click;
            // 
            // dataGridCidade
            // 
            dataGridCidade.AllowUserToAddRows = false;
            dataGridCidade.AllowUserToDeleteRows = false;
            dataGridCidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidade.Columns.AddRange(new DataGridViewColumn[] { Cidade, UF });
            dataGridCidade.Location = new Point(0, 32);
            dataGridCidade.MultiSelect = false;
            dataGridCidade.Name = "dataGridCidade";
            dataGridCidade.ReadOnly = true;
            dataGridCidade.RowHeadersWidth = 51;
            dataGridCidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCidade.Size = new Size(623, 248);
            dataGridCidade.TabIndex = 1;
            // 
            // Cidade
            // 
            Cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cidade.HeaderText = "Cidade";
            Cidade.MinimumWidth = 6;
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // UF
            // 
            UF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UF.HeaderText = "UF";
            UF.MinimumWidth = 6;
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // tabPageCadastroCidades
            // 
            tabPageCadastroCidades.BackColor = Color.LightGray;
            tabPageCadastroCidades.Controls.Add(label1);
            tabPageCadastroCidades.Controls.Add(btnCancelarCidade);
            tabPageCadastroCidades.Controls.Add(btnSalvarCidade);
            tabPageCadastroCidades.Controls.Add(textUF);
            tabPageCadastroCidades.Controls.Add(textCidade);
            tabPageCadastroCidades.Controls.Add(labelUF);
            tabPageCadastroCidades.Controls.Add(labelCidade);
            tabPageCadastroCidades.Location = new Point(4, 24);
            tabPageCadastroCidades.Name = "tabPageCadastroCidades";
            tabPageCadastroCidades.Padding = new Padding(3);
            tabPageCadastroCidades.Size = new Size(626, 312);
            tabPageCadastroCidades.TabIndex = 1;
            tabPageCadastroCidades.Text = "tabPage2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 24);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 5;
            label1.Text = "Cadastro Cidade";
            // 
            // btnCancelarCidade
            // 
            btnCancelarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarCidade.Location = new Point(3, 271);
            btnCancelarCidade.Name = "btnCancelarCidade";
            btnCancelarCidade.Size = new Size(84, 30);
            btnCancelarCidade.TabIndex = 3;
            btnCancelarCidade.Text = "Cancelar";
            btnCancelarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarCidade.UseVisualStyleBackColor = true;
            btnCancelarCidade.Click += btnCancelarCidade_Click;
            // 
            // btnSalvarCidade
            // 
            btnSalvarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvarCidade.Location = new Point(510, 271);
            btnSalvarCidade.Name = "btnSalvarCidade";
            btnSalvarCidade.Size = new Size(84, 30);
            btnSalvarCidade.TabIndex = 2;
            btnSalvarCidade.Text = "Salvar";
            btnSalvarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvarCidade.UseVisualStyleBackColor = true;
            btnSalvarCidade.Click += btnSalvarCidade_Click;
            // 
            // textUF
            // 
            textUF.Location = new Point(237, 173);
            textUF.Margin = new Padding(3, 2, 3, 2);
            textUF.Name = "textUF";
            textUF.Size = new Size(110, 23);
            textUF.TabIndex = 1;
            // 
            // textCidade
            // 
            textCidade.Location = new Point(237, 113);
            textCidade.Margin = new Padding(3, 2, 3, 2);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(110, 23);
            textCidade.TabIndex = 0;
            textCidade.TextChanged += textCidade_TextChanged;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(237, 155);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(21, 15);
            labelUF.TabIndex = 1;
            labelUF.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(237, 96);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 0;
            labelCidade.Text = "Cidade";
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 315);
            Controls.Add(tabControlCidades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CidadeForm";
            Text = "Cadastro Cidade";
            Load += CidadeForm_Load;
            tabControlCidades.ResumeLayout(false);
            tabPageConsultaCidades.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).EndInit();
            tabPageCadastroCidades.ResumeLayout(false);
            tabPageCadastroCidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCidades;
        private TabPage tabPageConsultaCidades;
        private Panel panelSuperior;
        private Button btnPesquisarCidade;
        private TextBox txtPesquisaCidade;
        private Panel panelInferior;
        private Button btnVisualizarCidade;
        private Button btnNovaCidade;
        private DataGridView dataGridCidade;
        private TabPage tabPageCadastroCidades;
        private TextBox textUF;
        private TextBox textCidade;
        private Label labelUF;
        private Label labelCidade;
        private Button btnCancelarCidade;
        private Button btnSalvarCidade;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
        private Label label1;
        private Button btnExcluirDaGrid;
    }
}