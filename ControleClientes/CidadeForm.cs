using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ControleClientes
{
    public partial class CidadeForm : Form
    {
        private readonly CidadeRepository _repository;
        private int? editingId = null;

        public CidadeForm()
        {
            _repository = new CidadeRepository();
            InitializeComponent();
            AtualizarGrid();

        }

        private void AtualizarGrid()
        {
            var cidades = _repository.ListarTodos();
            dataGridCidade.DataSource = cidades;
            dataGridCidade.Columns["uf"].Visible = false;
            dataGridCidade.Columns["Cidade"].Visible = false;
            dataGridCidade.Columns["Clientes"].Visible = false;
        }

        private void LimparCampos()
        {
            textCidade.Clear();
            textUF.Clear();
            editingId = null;
        }

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {

            var clientes = _repository.ObterPorNome(txtPesquisaCidade.Text);
            dataGridCidade.AutoGenerateColumns = false;
            dataGridCidade.DataSource = clientes;
        }

        private void btnNovaCidade_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tabControlCidades.SelectTab(tabPageCadastroCidades);
        }

        private void btnVisualizarCidade_Click(object sender, EventArgs e)
        {
            if (dataGridCidade.SelectedRows.Count == 0)
            {
                return;
            }
            var cidade = (Cidade)dataGridCidade.SelectedRows[0].DataBoundItem;
            textCidade.Text = cidade.Nome;
            textUF.Text = cidade.UF;
            editingId = cidade.Id;
            tabControlCidades.SelectTab(tabPageCadastroCidades);
        }

        private void btnExcluirCidade_Click(object sender, EventArgs e)
        {
            if (dataGridCidade.SelectedRows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Excluir Registro", "Cidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabControlCidades.SelectTab(tabPageConsultaCidades);
            }
            var cidade = (Cidade)dataGridCidade.SelectedRows[0].DataBoundItem;
            _repository.Remover(cidade.Id);
            AtualizarGrid();
            tabControlCidades.SelectTab(tabPageConsultaCidades);
        }

        private void btnSalvarCidade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCidade.Text))
            {
                MessageBox.Show("O nome da cidade é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCidade.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textUF.Text))
            {
                MessageBox.Show("O UF é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textUF.Focus();
                return;
            }

            var cidade = new Cidade
            {
                Nome = textCidade.Text.Trim(),
                UF = textUF.Text.Trim(),
            };

            if (editingId == null)
                _repository.Adicionar(cidade);
            else
            {
                cidade.Id = editingId.Value;
                _repository.Atualizar(cidade);
            }

            LimparCampos();
            AtualizarGrid();
            tabControlCidades.SelectTab(tabPageConsultaCidades);
        }


        private void btnCancelarCidade_Click(object sender, EventArgs e)
        {
            tabControlCidades.SelectTab(tabPageConsultaCidades);
        }

        private void textCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void CidadeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

