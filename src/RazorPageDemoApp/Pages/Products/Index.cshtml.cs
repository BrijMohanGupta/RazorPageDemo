using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemoApp.Data;
using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Pages.Products
{
    [Authorize(Roles = "Admin,Maintainer,ReadOnly")]
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _repo;
        public List<Product> Products { get; set; } = new();

        public IndexModel(ProductRepository repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
            Products = _repo.GetAll();
        }
    }
}
