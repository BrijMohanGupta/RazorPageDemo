using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemoApp.Data;
using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new();

        private readonly ProductRepository productRepo;

        public CreateModel(ProductRepository repo)
        {
            productRepo = repo;
        }

        public void OnGet() { }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            productRepo.Add(Product);
            return RedirectToPage("Index");
        }
    }
}
