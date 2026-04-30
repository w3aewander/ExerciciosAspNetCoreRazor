using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MinhaAppSqlite.Models
{
    public class Produto
    {
        public int Id { get; set; } // Chave Primária (Auto-incremento)
        
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
    }
}