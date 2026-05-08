namespace MinhaAppSqlite.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;

    }
}
