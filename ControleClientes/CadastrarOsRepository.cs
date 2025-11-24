namespace ControleClientes
{
    internal class CadastrarOsRepository
    {
        private readonly AppDbContext _context;

        public CadastrarOsRepository()
        {
            _context = new AppDbContext();
        }

        public void AdicionarTipo(ModeloOs os)
        {
            _context.TiposDeOs.Add(os);
            _context.SaveChanges();
        }

        public List<ModeloOs> ListarTodosTipos()
        {
            return _context.TiposDeOs.ToList();
        }

        public ModeloOs ObterporIdTipo(int id)
        {
            return _context.TiposDeOs.Find(id);
        }

        public void AtualizarTipo(ModeloOs os)
        {
            ModeloOs tipoOs = ObterporIdTipo (os.Id);
            if(tipoOs != null)
            {
                tipoOs.Id = os.Id;
                tipoOs.Nome = os.Nome;
                _context.SaveChanges();
            }
        }

        public void RemoverTipo(int id)
        {
            var tipoOs = _context.TiposDeOs.Find(id);
            if (tipoOs != null)
            {
                _context.TiposDeOs.Remove(tipoOs);
                _context.SaveChanges();
            }
        }
    }
}
