using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;

namespace MinhaAppSqlite.Pages.Produto
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Models.Produto> Produtos { get; set; } = new List<Models.Produto>();

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }
    }
}