namespace ControleClientes
{
    public class OsItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem { get; set; }
        public int OsId { get; set; }
        public Os Os { get; set; }

        public int TipoOsId { get; set; }
        public ModeloOs TipoOs { get; set; }
    }
}
