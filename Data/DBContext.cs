namespace MinhaAppSqlite.Data;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; } // Representa a tabela no banco
    public DbSet<Cliente> Clientes { get; set; } // Representa a tabela no banco

    public DbSet<ItemPedido> ItensPedidos { get; set; } // Representa a tabela no banco
    public DbSet<Pedido> Pedidos { get; set; } // Representa a tabela no banco
    public DbSet<Vendedor> Vendedores { get; set; } // Representa a tabela no banco
    public DbSet<Venda> Vendas { get; set; } // Representa a tabela no banco

    public DbSet<Endereco> Enderecos { get; set; } // Representa a tabela no banco

    public DbSet<Estoque> Estoque { get; set; }

}
