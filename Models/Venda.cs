namespace MinhaAppSqlite.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public required Pedido Pedido { get; set; }
    }

}
