using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;
using MinhaAppSqlite.Models;

namespace MinhaAppSqlite.Pages.Venda
{
    public class DetailsModel : PageModel
    {
        private readonly MinhaAppSqlite.Data.AppDbContext _context;

        public DetailsModel(MinhaAppSqlite.Data.AppDbContext context)
        {
            _context = context;
        }

        public Models.Venda Venda { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas.FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }
            else
            {
                Venda = venda;
            }
            return Page();
        }
    }
}
