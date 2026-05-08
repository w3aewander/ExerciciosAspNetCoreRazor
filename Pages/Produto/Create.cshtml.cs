using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinhaAppSqlite.Data;


namespace MinhaAppSqlite.Pages.Produto
{
    public class CreateModel(AppDbContext context) : PageModel
    {
        private readonly AppDbContext _context = context;

        // Property to bind the Product model to the form
        [BindProperty]
        public Models.Produto Produto { get; set; }



        public AppDbContext Context => _context;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            Context.Produtos.Add(Produto);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}