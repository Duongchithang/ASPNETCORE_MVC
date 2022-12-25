using WebApplication4.Models;
namespace WebApplication4.Services
{
    public class ProductServices
    {
        private List<Product> products = new List<Product>();
        public ProductServices()
        {
            Console.WriteLine("Contructor Duoc chay");
            LoadProducts();
        }
        public Product Find(int id)
        {
            var query_product = from p in products where p.Id == id select p;
            return query_product.FirstOrDefault();
        }
        public List<Product> GetProducts() => products;
        public void LoadProducts()
        {
            products.Clear();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Iphone",
                Price = 900,
                Description = "Dien Thoai Iphone acb,...."
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Samsung",
                Price = 700,
                Description = "Dien Thoai SamSung acb,...."
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Nokia",
                Price = 800,
                Description = "Dien Thoai Nokia acb,...."
            });
        }

        internal object OrderBy()
        {
            throw new NotImplementedException();
        }
    }
}
