using Assignment.Models;

namespace Assignment.Data
{
    public class ProductData
    {
        List<Product> products {  get; set; } = new List<Product>();
        public ProductData()
        {
            products.Add(new Product { ID = 1, Name = "Product1", Description = "This Product is Ay Haga1", Img = "1.jpg", Price = 150, CategoryID = 1});
            products.Add(new Product { ID = 2, Name = "Product2", Description = "This Product is Ay Haga2", Img = "2.jpg", Price = 120, CategoryID = 2 });
            products.Add(new Product { ID = 3, Name = "Product3", Description = "This Product is Ay Haga3", Img = "2.jpg", Price = 110, CategoryID = 3 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
