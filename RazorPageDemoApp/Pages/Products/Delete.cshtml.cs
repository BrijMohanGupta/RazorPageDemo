using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemoApp.Data;

namespace RazorPageDemoApp.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly ProductRepository _repo;

        public DeleteModel(ProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult OnGet(int id)
        {
            _repo.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
