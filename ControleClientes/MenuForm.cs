namespace ControleClientes
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            cliente.MdiParent = this;
            cliente.Show();

        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void íconesMinimizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CidadeForm cidadeForm = new CidadeForm();
            cidadeForm.MdiParent = this;
            cidadeForm.Show();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsForm osForm = new OsForm();
            osForm.Show();
        }

        private void tipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadast tipoForm = new Cadast();
            tipoForm.Show();
        }
    }
}
