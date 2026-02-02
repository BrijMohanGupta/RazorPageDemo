using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemoApp.Data;
using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new();

        public void OnGet()
        {
            Products = ProductRepository.GetAll();
        }
    }
}
