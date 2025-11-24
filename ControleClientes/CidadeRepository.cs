namespace ControleClientes
{
    public class CidadeRepository
    {
        public IEnumerable<Cidade> ObterPorNome(string nome)
        {
            return _context.Cidades
                .Where(c => c.Nome.ToLower().Contains(nome.ToLower()))
                .ToList();
        }


        private readonly AppDbContext _context;
        public CidadeRepository()
        {
            _context = new AppDbContext();
        }

        public void Adicionar(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            _context.SaveChanges();
        }

        public List<Cidade> ListarTodos()
        {
            return _context.Cidades.ToList();   
        }

        public Cidade ObterPorId(int id)
        {
            return _context.Cidades.Find(id);
        }

        public void Atualizar(Cidade cidade)
        {
            Cidade cidadeExistente = ObterPorId(cidade.Id);
            if(cidadeExistente != null)
            {
                cidadeExistente.Nome = cidade.Nome;
                cidadeExistente.UF = cidade.UF;
            }
        }

        public void Remover (int id)
        {
            var cidade = _context.Cidades.Find(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
                _context.SaveChanges();
            }
        }
       
    }
}
