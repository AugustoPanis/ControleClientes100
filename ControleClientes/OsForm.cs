using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace ControleClientes
{
    public partial class OsForm : Form
    {
        private List<OsItem> _itensServico = new List<OsItem>();
        private readonly OsRepository _repository;
        private readonly TipoOsRepository _tosRepository;
        private int? editingId = null;

        private int? LinhaParaEditar = null;

        List<Cliente> _clientes;

        List<ModeloOs> _tos = new List<ModeloOs>();

        public OsForm()
        {
            _repository = new OsRepository();
            _tosRepository = new TipoOsRepository();
            InitializeComponent();
            CarregarClientes();
            CarregarTiposDeOs();
            CarregarStatus();
            AtualizarGrid();
        }

        List<StatusItem> ListaStatus = new List<StatusItem>
        {
            new StatusItem {Valor = statusOs.Aguardando_Orcamento, ValorNome = "Aguardando Avaliação" },
            new StatusItem {Valor = statusOs.Em_Avaliacao, ValorNome = "Em Avaliação"},
            new StatusItem {Valor = statusOs.Aguardando_Aprovacao, ValorNome = "Aguardando Aprovação"},
            new StatusItem {Valor = statusOs.Aprovado, ValorNome = "Aprovado"},
            new StatusItem {Valor = statusOs.Recusado, ValorNome = "Reprovado"},
            new StatusItem {Valor = statusOs.Finalizado, ValorNome = "Finalizado"},
        };

        private void CarregarStatus()
        {
            comboBoxStatus.DataSource = ListaStatus;
            comboBoxStatus.DisplayMember = "ValorNome";
            comboBoxStatus.ValueMember = "Valor";
        }

        private void AtualizarGridItens()
        {

            var listaParaGrid = _itensServico.Select(item => new
            {
                Servico = item.TipoOs.Nome,
                Quantidade = item.Quantidade,
                ValorUnitario = item.ValorUnitario,
                ValorTotal = item.ValorTotalItem
            }).ToList();

            dataGridOS.DataSource = null;
            dataGridOS.DataSource = listaParaGrid;

            if (dataGridOS.Columns.Contains("ValorUnitario"))
                dataGridOS.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
            if (dataGridOS.Columns.Contains("ValorTotal"))
                dataGridOS.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";

            dataGridOS.Columns["descricao"].HeaderText = "Descrição";
            dataGridOS.Columns["ValorTotalGeral"].HeaderText = "Valor";
        }

        public void CarregarClientes()
        {
            var clienteRepository = new ClienteRepository();
            _clientes = clienteRepository.ListarTodos();
            comboBoxCliente.DataSource = _clientes;
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.SelectedIndex = -1;

        }

        public void CarregarTiposDeOs()
        {
            var TipoRepository = new TipoOsRepository();
            _tos = TipoRepository.ListarTodosTipos();
            comboBoxTipoOs.DataSource = _tos;
            comboBoxTipoOs.DisplayMember = "Nome";
            comboBoxTipoOs.ValueMember = "Id";
            comboBoxTipoOs.SelectedIndex = -1;
        }

        private void LimparCampos()
        {
            comboBoxCliente.DataSource = null;
            textBoxDescricao.Clear();
            comboBoxCliente.SelectedIndex = -1;
            comboBoxTipoOs.SelectedIndex = -1;
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
            editingId = null;
            _itensServico.Clear();


        }

        public void AtualizarGrid()
        {
            dataGridOS.AutoGenerateColumns = false;
            var listaOs = _repository.ListarTodos();
            var listaGrid = listaOs.Select(os => new
            {

                Id = os.Id,
                ColunaNome = os.Cliente != null ? os.Cliente.Nome : "Sem Cliente",
                Descricao = os.Descricao,
                StatusNome = ListaStatus.FirstOrDefault(s => s.Valor == os.statusOs)?.ValorNome ?? os.statusOs.ToString(),
                ValorTotalGeral = os.ValorTotalGeral

            }).ToList();
            dataGridOS.DataSource = null;
            dataGridOS.DataSource = listaGrid;
        }


        private void buttonNovo_Click(object sender, EventArgs e)
        {
            CarregarTiposDeOs();
            LimparCampos();
            tabControlOS.SelectTab(tabPageCadastroOS);
            dataGridOS.DataSource = null;
            CarregarClientes();

        }

        private void buttonVizualizar_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            { return; }


            dynamic osSelecionada = dataGridOS.SelectedRows[0].DataBoundItem;
            int idSelecionado = osSelecionada.Id;

            Os osCompleta = _repository.ObterPorId(osSelecionada.Id);

            if (osCompleta == null)
            {
                MessageBox.Show("Não foi possível carregar a Ordem de Serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            LimparCampos();
            CarregarClientes();
            CarregarTiposDeOs();

            var os = new Os();
            var cliente = _clientes.FirstOrDefault(c => c.Id == osCompleta.ClienteId);
            comboBoxCliente.SelectedItem = cliente;
            textBoxDescricao.Text = osCompleta.Descricao;
            comboBoxStatus.SelectedItem = ListaStatus.FirstOrDefault(s => s.Valor == os.statusOs);

            _itensServico = osCompleta.Itens?.ToList() ?? new List<OsItem>();

            AtualizarGridItens();
            editingId = osCompleta.Id;
            tabControlOS.SelectTab(tabPageCadastroOS);
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedItem == null)
            {
                MessageBox.Show("Por Favor, Selecione um cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTipoOs.SelectedItem == null)
            {
                MessageBox.Show("Por Favor, Selecione um Tipo de OS.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribui o tipo de OS para cada item
            foreach (var item in _itensServico)
            {
                item.TipoOs = (ModeloOs)comboBoxTipoOs.SelectedItem;
            }

            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;
            StatusItem listaStatus = (StatusItem)comboBoxStatus.SelectedItem;

            var os = new Os
            {
                Descricao = textBoxDescricao.Text.Trim(),
                ClienteId = cliente.Id,
                statusOs = listaStatus.Valor,
                Itens = _itensServico,
                ValorTotalGeral = _itensServico.Sum(item => item.ValorTotalItem)
            };

            if (editingId == null)
            {
                _repository.Adicionar(os);
            }
            else
            {
                os.Id = editingId.Value;
                _repository.Atualizar(os);
            }

            LimparCampos();
            tabControlOS.SelectTab(tabPageConsultaOS);
            CarregarTiposDeOs();
            AtualizarGrid();


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            bool existeAlgoPreenchido =
                comboBoxCliente.SelectedIndex != -1 ||
                comboBoxTipoOs.SelectedIndex != -1 ||
                !string.IsNullOrWhiteSpace(textBoxDescricao.Text) ||
                _itensServico.Count > 0;

            if (existeAlgoPreenchido)
            {
                var resp = MessageBox.Show(
                    "Você não salvou sua Ordem de Serviço. Deseja salvá-la?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resp == DialogResult.Yes)
                {
                    buttonSalvar.PerformClick();
                }
            }

            // volta pra consulta
            tabControlOS.SelectTab(tabPageConsultaOS);
            AtualizarGrid();
        }



        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Excluir Registro", "Ordem de Serviço", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabControlOS.SelectTab(tabPageConsultaOS);
            }
            var linha = dataGridOS.SelectedRows[0].DataBoundItem;
            int id = (int)linha.GetType().GetProperty("Id").GetValue(linha);

            _repository.Remover(id);
            AtualizarGrid();

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            var os = _repository.Pesquisar(textBoxPesquisarOs.Text);
            dataGridOS.AutoGenerateColumns = false;
            dataGridOS.DataSource = os;
        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            var tipoOs = new Cadast();
            tipoOs.MdiParent = this.MdiParent;
            tipoOs.Show();
        }



        private void CalcularTotal()
        {
            bool vValido = decimal.TryParse(textBoxValorCadastro.Text, out decimal valor);

            bool qValido = decimal.TryParse(textBoxQuantidade.Text, out decimal quantidade);

            if (vValido && qValido)
            {
                decimal total = valor * quantidade;

                textBoxValorTotal.Text = total.ToString("C");
            }
            else
            {
                textBoxValorTotal.Text = "";

            }
        }


        private void textBoxValorTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void textBoxValorCadastro_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {

            if (comboBoxTipoOs.SelectedItem == null || comboBoxTipoOs.SelectedItem == "")
            {
                MessageBox.Show("Selecione um Tipo de Serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ModeloOs tipoSelecionado = (ModeloOs)comboBoxTipoOs.SelectedItem;

            if (LinhaParaEditar == null)
            {
                decimal.TryParse(textBoxValorCadastro.Text, out decimal valorUnitario);


                string strValorTotal = textBoxValorTotal.Text
                    .Replace("R$", "")
                    .Trim();

                decimal.TryParse(strValorTotal, out decimal valorTotalItem);

                var novoItem = new OsItem
                {
                    TipoOsId = tipoSelecionado.Id,
                    TipoOs = tipoSelecionado,
                    Quantidade = quantidade,
                    ValorUnitario = valorUnitario,
                    ValorTotalItem = valorTotalItem
                };

                _itensServico.Add(novoItem);
            }
            else
            {
                int index = dataGridOS.CurrentRow.Index;

                var ItemEdicao = _itensServico[index];

                ModeloOs editarTipo = (ModeloOs)comboBoxTipoOs.SelectedItem;
                decimal.TryParse(textBoxValorCadastro.Text, out decimal valorUnitario);


                string strValorTotal = textBoxValorTotal.Text.Replace("R$", "").Trim();
                decimal.TryParse(strValorTotal, out decimal valorTotalItem);

                ItemEdicao.TipoOsId = editarTipo.Id;
                ItemEdicao.TipoOs = editarTipo;
                ItemEdicao.Quantidade = quantidade;
                ItemEdicao.ValorUnitario = valorUnitario;
                ItemEdicao.ValorTotalItem = valorTotalItem;

                MessageBox.Show("Item Atualizado!");

            }
            AtualizarGridItens();
            AtualizarGrid();


            comboBoxTipoOs.SelectedIndex = -1;
            textBoxValorCadastro.Clear();
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
        }

        private void comboBoxTipoOs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoOs.SelectedItem is ModeloOs tiposelecionado)
            {
                textBoxValorCadastro.Text = tiposelecionado.Valor.ToString("N2");
            }
            else
            {
                comboBoxTipoOs.SelectedIndex = -1;
                textBoxValorCadastro.Text = "";
            }
        }

        private void buttonRemoverServico_Click(object sender, EventArgs e)
        {

            if (dataGridOS.CurrentRow == null)
            {
                MessageBox.Show("É necessário selecionar um linha inteira para remover o arquivo!");
                return;
            }

            if (MessageBox.Show("Deseja remover este item da OS?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int linha = dataGridOS.CurrentRow.Index;

            if (linha >= 0 && linha < _itensServico.Count)
            {
                _itensServico.RemoveAt(linha);

                AtualizarGridItens();
            }

        }

        private void dataGridCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _itensServico.Count)
            {
                LinhaParaEditar = e.RowIndex;

                DataGridViewRow linha = dataGridOS.Rows[e.RowIndex];

                var itemSelecionado = _itensServico[e.RowIndex];

                textBoxValorCadastro.Text = itemSelecionado.ValorUnitario.ToString("C2");
                comboBoxTipoOs.SelectedValue = itemSelecionado.TipoOsId;
                textBoxQuantidade.Text = itemSelecionado.Quantidade.ToString();
                textBoxValorTotal.Text = itemSelecionado.ValorTotalItem.ToString("C2");


            }
        }

        private void labelTipoDeOrdem_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCadastroOS_Click(object sender, EventArgs e)
        {

        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


