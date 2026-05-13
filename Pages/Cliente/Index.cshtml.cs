using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;
using MinhaAppSqlite.Models;

namespace MinhaAppSqlite.Pages_Cliente
{
    public class IndexModel : PageModel
    {
        private readonly MinhaAppSqlite.Data.AppDbContext _context;

        public IndexModel(MinhaAppSqlite.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
