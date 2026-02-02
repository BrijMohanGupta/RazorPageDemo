using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemoApp.Data;
using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly ProductRepository _repo;

        public EditModel(ProductRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Product Product { get; set; } = new();

        public void OnGet(int id)
        {
            Product = _repo.GetById(id)!;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _repo.Update(Product);
            return RedirectToPage("Index");
        }
    }
}
