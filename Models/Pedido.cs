using Microsoft.VisualBasic;

namespace MinhaAppSqlite.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateAndTime Data { get; set; }

        public Cliente Cliente { get; set; } = new Cliente(); // Inicializa o cliente com um novo objeto
        public List<Produto> Itens { get; set; } = new List<Produto>(); // Inicializa a lista de itens com uma nova lista


    }
}
