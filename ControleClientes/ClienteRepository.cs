namespace ControleClientes
{
    public class ClienteRepository
    {

        public IEnumerable<Cliente> ObterPorNome(string nome)
        {
            return _context.Clientes
                .Where(c => c.Nome.ToLower().Contains(nome.ToLower()))
                .OrderByDescending(c => c.Nome.ToLower().StartsWith(nome.ToLower())) // aparece primeiro
                .ThenBy(c => c.Nome) // ordenação secundária
                .ToList();

        }

        private readonly AppDbContext _context;
        public ClienteRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.Find(id);
        }
        public void Atualizar(Cliente cliente)
        {
            Cliente clienteExistente = ObterPorId(cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Genero = cliente.Genero;
                clienteExistente.estadocivil = cliente.estadocivil;
                clienteExistente.Cep = cliente.Cep;
                clienteExistente.Logradouro = cliente.Logradouro;
                clienteExistente.Complemento = cliente.Complemento;
                clienteExistente.Bairro = cliente.Bairro;
                clienteExistente.Localidade = cliente.Localidade;
                clienteExistente.Uf = cliente.Uf;
                clienteExistente.CidadeId = cliente.CidadeId; 
                _context.SaveChanges();
            }


        }
        public void Remover(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}