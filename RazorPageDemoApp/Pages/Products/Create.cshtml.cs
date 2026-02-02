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

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ProductRepository.Add(Product);
            return RedirectToPage("Index");
        }
    }
}
