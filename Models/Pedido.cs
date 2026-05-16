namespace MinhaAppSqlite.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        // Relacionamentos existentes
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public Vendedor Vendedor { get; set; } = null!;

        // UM pedido contém VÁRIOS itens/produtos na tabela de itens
        public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
    }
}
