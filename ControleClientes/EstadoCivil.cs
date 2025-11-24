namespace ControleClientes
{
    public enum estadocivil
    {
        Solteiro,
        Casado,
        Uniao_Estavel,
        Divorciado,
        Separado_judicialmente,
        Viúvo
    }

    class ItemEstadoCivil
    {
        public estadocivil Valor { get; set; }
        public string Descricao { get; set; }
    }
}

