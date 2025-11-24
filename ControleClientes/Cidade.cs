namespace ControleClientes
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string UF { get; set; }

        public ICollection<Cliente> Clientes { get; set; }


    }
}
