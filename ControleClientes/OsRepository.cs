using Microsoft.EntityFrameworkCore;

namespace ControleClientes
{
    public class OsRepository
    {
        public IEnumerable<Os> Pesquisar(string termo)
        {
            return _context.OrdemServico.AsNoTracking().Include(o => o.Cliente).Where(o => o.Cliente.Nome.ToLower().Contains(termo.ToLower()) ||
            o.Descricao.ToLower().Contains(termo.ToLower()) ||
            o.Id.ToString().Contains(termo)).ToList();
        }

        private readonly AppDbContext _context;

        public OsRepository()
        {
            _context = new AppDbContext();
        }

        public void Adicionar(Os os)
        {

            _context.OrdemServico.Add(os);
            _context.SaveChanges();
        }

        public List<Os> ListarTodos()
        {

            return _context.OrdemServico
                .Include(o => o.Cliente)

                .ToList();
        }

        public Os ObterPorId(int id)
        {
            return _context.OrdemServico
                .AsNoTracking()
                .Include(o => o.Itens)
                    .ThenInclude(item => item.TipoOs)
                .FirstOrDefault(o => o.Id == id);
        }

        public void Atualizar(Os osAtualizada)
        {
            var osExistente = _context.OrdemServico
                           .Include(o => o.Itens)
                           .FirstOrDefault(o => o.Id == osAtualizada.Id);

            if (osExistente != null)
            {
                osExistente.Descricao = osAtualizada.Descricao;
                osExistente.ClienteId = osAtualizada.ClienteId;
                osExistente.ValorTotalGeral = osAtualizada.ValorTotalGeral;
                osExistente.statusOs = osAtualizada.statusOs;


                _context.OsItens.RemoveRange(osExistente.Itens);

                foreach (var item in osAtualizada.Itens)
                {
                    item.Id = 0;
                    item.OsId = osExistente.Id;

                    item.Os = null;

                    item.TipoOs = null;

                    _context.OsItens.Add(item);
                }

                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var os = _context.OrdemServico.Find(id);
            if (os != null)
            {

                _context.OrdemServico.Remove(os);
                _context.SaveChanges();
            }
        }
    }
}