using LivroApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LivroApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
    }
}
