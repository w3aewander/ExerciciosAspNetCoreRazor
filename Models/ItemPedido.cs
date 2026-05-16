namespace MinhaAppSqlite.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }

        // Chave estrangeira para o Pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = null!;

        // Chave estrangeira para o Produto (Cada linha do item é UM produto)
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;

        public int Quantidade { get; set; }
    }
}
