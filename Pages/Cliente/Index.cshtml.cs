using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;

namespace MinhaAppSqlite.Pages.Cliente
{
   
        public class IndexModel : PageModel
        {
            private readonly AppDbContext _context;

            public IndexModel(AppDbContext context)
            {
                _context = context;
            }

            public IList<Models.Cliente> Clientes { get; set; } = new List<Models.Cliente>();

            public async Task OnGetAsync()
            {
                Clientes = await _context.Clientes
                    .OrderBy(c => c.Nome)
                    .ToListAsync();
            }
        }

}
