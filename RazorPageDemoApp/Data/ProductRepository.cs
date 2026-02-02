using RazorPageDemoApp.Models;

namespace RazorPageDemoApp.Data
{
    public static class ProductRepository
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Quantity = 5, Price = 65000, Description = "Business laptop" },
            new Product { Id = 2, Name = "Mouse", Quantity = 50, Price = 500, Description = "Wireless mouse" }
        };

        public static List<Product> GetAll() => _products;

        public static Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public static void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
    }
}
