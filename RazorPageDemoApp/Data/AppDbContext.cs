using Microsoft.EntityFrameworkCore;
using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}
