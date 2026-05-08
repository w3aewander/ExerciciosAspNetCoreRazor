using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhaAppSqlite.Data;
using MinhaAppSqlite.Models;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;

    public EditModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Produto Produto { get; set; } = null!;

    // GET: /Produtos/Edit?id=3
    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
            return NotFound();

        Produto = await _context.Produtos
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);

        if (Produto == null)
            return NotFound();

        return Page();
    }

    // POST: salvar alterações
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        _context.Attach(Produto).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProdutoExiste(Produto.Id))
                return NotFound();
            else
                throw;
        }

        return RedirectToPage("Index");
    }

    private bool ProdutoExiste(int id)
    {
        return _context.Produtos.Any(e => e.Id == id);
    }
}