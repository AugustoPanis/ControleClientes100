namespace ControleClientes
{
    public class ModeloOs
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public virtual ICollection<OsItem> OsItens { get; set; } = new List<OsItem>();
    }
}
