namespace ControleClientes
{
    public class Os
    {
        public int Id { get; set; }
        public decimal ValorTotalGeral { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public statusOs statusOs { get; set; }
        public virtual ICollection<OsItem> Itens { get; set; } = new List<OsItem>();

    }
}