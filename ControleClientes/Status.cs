namespace ControleClientes
{
    public enum statusOs
    {
        Aguardando_Orcamento,
        Em_Avaliacao,
        Aguardando_Aprovacao,
        Aprovado,
        Recusado,
        Finalizado
    }

    class StatusItem
    {
        public statusOs Valor { get; set; }
        public string ValorNome { get; set; }
    }
}
