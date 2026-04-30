namespace MinhaAppSqlite.Data;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; } // Representa a tabela no banco
    public DbSet<Cliente> Clientes { get; set; } // Representa a tabela no banco

}
