using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;
using MinhaAppSqlite.Models;

namespace MinhaAppSqlite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produtos { get; set; } = new List<Produto>();

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }
    }
}