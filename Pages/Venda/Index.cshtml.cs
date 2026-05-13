using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MinhaAppSqlite.Pages.Venda
{
    public class IndexModel : PageModel
    {
        private readonly MinhaAppSqlite.Data.AppDbContext _context;

        public IndexModel(MinhaAppSqlite.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Models.Venda> Venda { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Venda = await _context.Vendas.ToListAsync();
        }
    }
}
