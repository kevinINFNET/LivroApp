using LivroApp.Data;
using LivroApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LivroApp.Pages
{
public class IndexModel : PageModel
{
private readonly AppDbContext _context;
public IndexModel(AppDbContext context)
{
   _context = context;
}
 public IList<Livro> Livros { get; set; } = new List<Livro>();
public void OnGet()
{
  Livros = _context.Livros.ToList();
}
public IActionResult OnPostDelete(int id)
{
  var livro = _context.Livros.Find(id);
  if (livro != null)
 {
   _context.Livros.Remove(livro);
    _context.SaveChanges();
   }
 return RedirectToPage();
     }
   }
}
