namespace ControleClientes
{
    public class Cliente
    {

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public ICollection<Os> Os { get; set; }
        public estadocivil estadocivil { get; set; }
        public Genero Genero { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public string Cep { get; set; }
    }
}
