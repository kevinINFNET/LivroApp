using LivroApp.Data;
using LivroApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LivroApp.Pages
{
public class CreateModel : PageModel
{
 private readonly AppDbContext _context;
 [BindProperty]
public Livro Livro { get; set; } = new Livro();
 public CreateModel(AppDbContext context)
{
_context = context;
 }
  public IActionResult OnPost()
{
  if (!ModelState.IsValid)
{
  return Page();
 }
 _context.Livros.Add(Livro);
 _context.SaveChanges();
  return RedirectToPage("Index");
     }
  }
}
