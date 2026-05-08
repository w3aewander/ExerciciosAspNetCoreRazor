namespace MinhaAppSqlite.Models
{
    public class Estoque
    {

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public string Unidade { get; set; }

        public int Quantidade { get; set; }
    }
}
